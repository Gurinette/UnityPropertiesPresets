using UnityEditor;

[CustomEditor(typeof(PropertiesPresetsBase), true)]
public class PropertiesPresetsEditor : Editor
{
    private int newSelection = 0;

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Current Active Preset", EditorStyles.boldLabel);

        IPropertiesPresets properitesPresets = (IPropertiesPresets)target;

        string[] presetNames = properitesPresets.GetPresetsNames();

        // If there are no presets, draw the default inspector and return.
        if (presetNames == null || presetNames.Length == 0)
        {
            DrawDefaultInspector();
            return;
        }

        int previousSelection = properitesPresets.CurrentActivePresetIndex;

        newSelection = previousSelection;
        newSelection = EditorGUILayout.Popup(newSelection, presetNames);

        properitesPresets.SetActivePresetIndex(newSelection);

        DrawDefaultInspector();

        if (previousSelection != newSelection)
        {
            EditorUtility.SetDirty(target);
        }
    }
}