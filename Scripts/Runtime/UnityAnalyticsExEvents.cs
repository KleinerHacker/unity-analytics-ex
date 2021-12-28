using UnityEngine;

namespace UnityAnalyticsEx.Runtime.analytics_ex.Scripts.Runtime
{
    public static class UnityAnalyticsExEvents
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        public static void Initialize()
        {
            Debug.Log("Initialize analytics system");
            var allow = AnalyticsEx.IsAnalyticsActivatedEx.GetValueOrDefault(false);
        }
    }
}