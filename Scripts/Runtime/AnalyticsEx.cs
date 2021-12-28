using UnityEngine.Analytics;
using UnityPrefsEx.Runtime.prefs_ex.Scripts.Runtime.Utils;

namespace UnityAnalyticsEx.Runtime.analytics_ex.Scripts.Runtime
{
    /// <summary>
    /// Extensions for Unity Analytics System
    /// </summary>
    public static class AnalyticsEx
    {
        private const string AnalyticsKey = "analytics";

        /// <summary>
        /// Returns that analytics is activated or not or NULL if analytics settings is open
        /// </summary>
        public static bool? IsAnalyticsActivatedEx => PlayerPrefsEx.HasKey(AnalyticsKey) ? PlayerPrefsEx.GetBool(AnalyticsKey, false) : null;

        /// <summary>
        /// Returns that analytics is activated or not. In case of no settings was found it returns FALSE.
        /// </summary>
        public static bool IsAnalyticsActivated => IsAnalyticsActivatedEx.GetValueOrDefault(false);

        /// <summary>
        /// Activate analytics and store it to settings
        /// </summary>
        public static void ActivateAnalytics()
        {
            PlayerPrefsEx.SetBool(AnalyticsKey, true, true);
            Analytics.enabled = true;
        }

        /// <summary>
        /// Deactivate analytics and store it to settings
        /// </summary>
        public static void DeactivateAnalytics()
        {
            PlayerPrefsEx.SetBool(AnalyticsKey, false, true);
            Analytics.enabled = false;
        }
    }
}