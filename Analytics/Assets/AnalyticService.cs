using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace GameServices
{
    public class AnalyticService : MonoBehaviour, IService
    {
        private Dictionary<string, object> customEventParams = new Dictionary<string, object>();
        public void Initialize()
        {
            AnalyticsResult.GameStart();
            levelCapReached("12345", "Desert Swamp");
              
            Debug.Log("Analytic Service manager booted up");
        }
        public void levelCapReached(string playerID, string levelName)
        {
            customEventParams.Clear();
            customEventParams.Add("player_ID", playerID);
            customEventParams.Add("level name", levelName);
            AnalyticsResult eventResult = AnalyticsEvent.Custom("level cap reached", customEventParams);
            Debug.LogFormat("Custom event lauched", eventResult);
        }
    }
    
}



