using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;
using UnityEngine.Advertisements;
using ShowResult = UnityEngine.Monetization.ShowResult;
using UnityEngine.Analytics;
namespace GameServices
{
    public class AdService : MonoBehaviour, IService
    {
        private string iOSGameID = "2895657";
        private string placementID_NonRewarded = "video";
        private string placementID_Rewarded = "rewardedVideo";
        private string placementID_AR = "arPlacement";
        private string placementID_Banner = "banner";
        private Dictionary<string, object> customEventParams=new Dictionary<string, object>();
        private PlacementContent arContent;

        private bool testMode = true;

        public void Initialize()
        {
#if UNITY_IOS || UNITY_ANDROID
            Monetization.Initialize(iOSGameID, testMode);
            Monetization.onPlacementContentReady += ContentReady;
            //DisplayNonRewardedAd();

            Advertisement.Initialize(iOSGameID, testMode);
            StartCoroutine(WaitAndDisplayBanner());
#else
            Debug.LogWarning("The current platform doesn't support Unity Monetization.");
#endif
        }

        public void DisplayNonRewardedAd()
        {
            if(!Monetization.IsReady(placementID_NonRewarded))
            {
                Debug.LogWarningFormat("Placement <{0}> not ready to display.", placementID_NonRewarded);
                return;
            }

            ShowAdPlacementContent adContent = Monetization.GetPlacementContent(placementID_NonRewarded) as ShowAdPlacementContent;

            if (adContent != null)
                adContent.Show();
            else
                Debug.LogWarning("Placement content returned null.");
        }

        public void DisplayRewardedAd()
        {
            StartCoroutine(WaitAndDisplayRewardedAd());
        }

        public IEnumerator WaitAndDisplayRewardedAd()
        {
            yield return new WaitUntil(() => Monetization.IsReady(placementID_Rewarded));

            ShowAdPlacementContent adContent = Monetization.GetPlacementContent(placementID_Rewarded) as ShowAdPlacementContent;
            adContent.gamerSid = "[CALLBACK SERVER ID HERE]";

            ShowAdCallbacks callbackOptions = new ShowAdCallbacks();
            callbackOptions.finishCallback += RewardCallback;

            if (adContent != null)
                adContent.Show(callbackOptions);
            else
                Debug.LogWarning("Placement content returned null.");
            customEventParams.Add("ar_content", false);
            AnalyticsResult eventResult= AnalyticsEvent.adStart(true, null, placementID_Rewarded, customEventParams);
            Debug.LogFormat("Event result", eventResult);
        }

        private void RewardCallback(ShowResult result)
        {
            switch(result)
            {
                case ShowResult.Finished:
                    Debug.Log("Rewards for everyone!");
                    break;
                case ShowResult.Skipped:
                    Debug.Log("Ad skpped, no rewards.");
                    break;
                case ShowResult.Failed:
                    Debug.Log("Ad failed to display.");
                    break;
            }
        }

        public void DisplayARContent() 
        {
            ShowAdPlacementContent adContent = arContent as ShowAdPlacementContent;

            if (adContent != null)
                adContent.Show();
            else
                Debug.LogWarning("AR placement returned null.");
        }

        private void ContentReady(object sender, PlacementContentReadyEventArgs e)
        {
            if(e.placementId == placementID_AR)
            {
                arContent = e.placementContent;
                Debug.Log("AR placement is ready to go.");
            }
        }

        private IEnumerator WaitAndDisplayBanner()
        {
            yield return new WaitUntil(() => Advertisement.IsReady(placementID_Banner));
            Advertisement.Banner.Show(placementID_Banner);
        }
    }
}
