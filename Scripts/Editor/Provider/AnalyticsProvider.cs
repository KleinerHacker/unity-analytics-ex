using UnityEditor;
using UnityEditorEx.Editor.editor_ex.Scripts.Editor.Utils;

namespace UnityAnalyticsEx.Editor.analytics_ex.Scripts.Editor.Provider
{
    public sealed class AnalyticsProvider : SettingsProvider
    {
        #region Static Area

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new AnalyticsProvider();
        }

        #endregion

        public AnalyticsProvider() : base("Project/Player/Analytics", SettingsScope.Project, new[] { "analytics" })
        {
        }

        public override void OnGUI(string searchContext)
        {
            ExtendedEditorGUILayout.SymbolField("Enable Analytics Support", "PCSOFT_ANALYTICS");
        }
    }
}