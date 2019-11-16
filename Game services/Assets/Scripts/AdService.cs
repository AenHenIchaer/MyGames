using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;
using UnityEngine.Advertisements;
using ShowResult = UnityEngine.Monetization.ShowResult;

namespace GameServices
{
    public class AdService : MonoBehaviour
    {
        private string iOSGameId = "2382492";
        private string placementID_NonRewarded = "video";
        private bool testMode = true;
        private string placementID_Rewarded = "rewardedVideo";
        private string placementID_AR = "arPlacement";
        private string placementID_Banner = "banner";
        private PlacementContent arContent;
        public void Initialize()
        {
#if UNITY_IOS || UNITY_ANDROID
            Monetization.Initialize(iOSGameID, testMode);
            Monetization.onPlacementContentReady+=ContentReady;
            //DisplayNonRewardedAd();
            Advertisement.Initialize(iOSGameID, testMode);
            StartCoroutine(WaitAdnDisplayBanner());
#else
            Debug.LogWarning("The current support doesnt support unity monetization");
#endif
        }
        public void DisplayNonRewardedAd()
        {
            if (!Monetization.IsReady(placementID_NonRewarded))
            {
                Debug.LogWarningFormat("Placement <{0}> not ready to display", placementID_NonRewarded);
                return;
            }
            ShowAdPlacementContent adContent = Monetization.GetPlacementContent(placementID_NonRewarded) as ShowAdPlacementContent;
            if (adContent != null)

                adContent.Show();

            else

                Debug.LogWarning("Placement content returned null");

        }
        public IEnumerator WaitAndDisplayRewardedAd()
        {
            yield return new WaitUntil(() => Monetization.IsReady(placementID_Rewarded));
            ShowAdPlacementContent adContent = Monetization.GetPlacementContent(placementID_Rewarded) as ShowAdPlacementContent;
            adContent.gamerSid = "[Callback server id here]";
            ShowAdCallbacks callbacksOptions = new ShowAdCallbacks();
            callbacksOptions.finishCallback += RewardCallback;
            if (adContent != null)
                adContent.Show(callbacksOptions);
            else
                Debug.LogWarning("Placemnt content returned null");


        }
        public void DisplayRewardedAd()
        {
            StartCoroutine(WaitAndDisplayRewardedAd);

        }

        private void RewardCallback(ShowResult result)

        {
            switch (result)
            {
                case ShowResult.Failed:
                    Debug.Log("Ad failed to display");
                    break;
                case ShowResult.Skipped:
                    Debug.Log("ad skipped, no rewards");
                    break;
                case ShowResult.Finished:
                    Debug.Log("Rewards for everyone");
                    break;
                default:
                    break;
            }
        }
        public void DisplayARCOntent()
        {
            ShowAdPlacementContent adContent = arContent as ShowAdPlacementContent;
            if (adContent != null)
                adContent.Show();
            else
                Debug.LogWarning("AR placemetn returned null");
          
        }
        private void ContentReady(object sender, PlacementContentReadyEventArgs e)
        {
            if (e.placementId==placementID_AR)
            {
                arContent = e.placementContent;
                Debug.Log("AR placement is ready to go");
            }
        }
        private IEnumerator WaitANdDisplayBanner()
        {
            yield return new WaitUntil(() => Advertisement.IsReady(placementID_Banner));
            Advertisement.Banner.Show(placementID_Banner);
        }
    }
}
