using System.Collections.Generic;
using UnityEngine;

public abstract class PropertiesPresets<T> : ScriptableObject, IPropertiesPresets<T> where T : Preset
{
    [SerializeField] protected List<T> presets = null;
    [HideInInspector] [SerializeField] private int currentActivePresetIndex = 0;

    public string CurrentActivePresetName { get { return CurrentActivePreset.PresetName; } }

    public int CurrentActivePresetIndex { get { return currentActivePresetIndex; } }

    public string[] GetPresetsNames()
    {
        // If there are no presets, return null.
        if (presets == null || presets.Count == 0) return null;

        string[] presetNames = new string[presets.Count];

        for (int i = 0; i < presets.Count; i++)
        {
            presetNames[i] = presets[i].PresetName;
        }

        return presetNames;
    }

    public void SetActivePresetIndex(int index)
    {
        currentActivePresetIndex = index;
    }

    protected T CurrentActivePreset
    {
        get
        {
            if (currentActivePresetIndex >= presets.Count)
            {
#if UNITY_EDITOR
                Debug.LogError("Preset of index " + currentActivePresetIndex + " not found in " + typeof(T).ToString());
#endif
                return default;
            }

            return presets[currentActivePresetIndex];
        }
    }
}

public class Preset
{
    [SerializeField] private string presetName = "";

    public string PresetName { get { return presetName; } }
}