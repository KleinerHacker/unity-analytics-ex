using UnityEngine;
using UnityEngine.Analytics;

namespace UnityAnalyticsEx.Runtime.analytics_ex.Scripts.Runtime
{
    public static class UnityAnalyticsExEvents
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        public static void Initialize()
        {
#if PCSOFT_ANALYTICS
            Debug.Log("Initialize analytics system");
            var allow = AnalyticsEx.IsAnalyticsActivatedEx.GetValueOrDefault(false);
            Analytics.enabled = allow;
            Debug.Log("> Analytics: " + allow);
#else
            Debug.Log("> Analytics deactivated");
            Analytics.enabled = false;
#endif
        }
    }
}