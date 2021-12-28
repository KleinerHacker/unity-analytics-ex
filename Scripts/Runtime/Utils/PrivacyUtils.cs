using UnityEngine;
using UnityEngine.Analytics;

namespace UnityAnalyticsEx.Runtime.analytics_ex.Scripts.Runtime.Utils
{
    /// <summary>
    /// Utility for privacy system
    /// </summary>
    public static class PrivacyUtils
    {
        /// <summary>
        /// Open the external page of Unity Privacy
        /// </summary>
        public static void OpenPrivacyInfo()
        {
            DataPrivacy.FetchPrivacyUrl(OnURLReceived, OnFailure);
        }
        
        private static void OnURLReceived(string url)
        {
            Application.OpenURL(url);
        }
        
        private static void OnFailure(string reason)
        {
            Debug.LogWarning($"Failed to get data privacy page URL: {reason}");
        }
    }
}