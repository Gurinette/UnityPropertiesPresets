using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PresetsOverridePreset))]
public class PresetsOverridePresetEditor : Editor
{
    private int[] newSelections;
    private string propertiesPresetsFieldName = "propertiesPresets";

    public override void OnInspectorGUI()
    {
        PresetsOverridePreset presetsOverride = (PresetsOverridePreset)target;
        List<PropertiesPresetsBase> propertiesPresets = presetsOverride.PropertiesPresets;

        if (propertiesPresets == null || propertiesPresets.Count == 0)
        {
            DrawDefaultInspector();
            return;
        }

        serializedObject.Update();
        DrawList(serializedObject.FindProperty(propertiesPresetsFieldName), propertiesPresets, presetsOverride);
        serializedObject.ApplyModifiedProperties();
    }

    private void DrawList(SerializedProperty list, List<PropertiesPresetsBase> propertiesPresets, PresetsOverridePreset presetsOverride)
    {
        bool setObjectDirty = false;
        newSelections = new int[propertiesPresets.Count];
        int[] oldSelections;

        if (presetsOverride.ActivePresetIndexesOverride == null || presetsOverride.ActivePresetIndexesOverride.Length == 0)
        {
            oldSelections = new int[propertiesPresets.Count];
        }
        else
        {
            oldSelections = presetsOverride.ActivePresetIndexesOverride;
        }

        EditorGUILayout.PropertyField(list, false);

        EditorGUI.indentLevel += 1;
        if (list.isExpanded)
        {
            EditorGUILayout.PropertyField(list.FindPropertyRelative("Array.size"));
            for (int i = 0; i < list.arraySize; i++)
            {
                string[] presetNames = propertiesPresets[i].GetPresetsNames();
                int previousSelection = oldSelections[i];
                newSelections[i] = EditorGUILayout.Popup(previousSelection, presetNames);
                EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));

                if (previousSelection != newSelections[i] && !setObjectDirty)
                {
                    setObjectDirty = true;
                }
            }
        }
        EditorGUI.indentLevel -= 1;

        GUILayout.Button(new GUIContent("+"));
        GUILayout.Button(new GUIContent("-"));

        if (setObjectDirty)
        {
            presetsOverride.ActivePresetIndexesOverride = newSelections;
            EditorUtility.SetDirty(target);
        }
    }
}
