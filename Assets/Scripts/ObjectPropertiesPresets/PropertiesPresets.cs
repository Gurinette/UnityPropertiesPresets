using System.Collections.Generic;
using UnityEngine;

public abstract class PropertiesPresets<T> : PropertiesPresetsBase where T : Preset
{
    [SerializeField]
    protected List<T> presets = null;

    public override string CurrentActivePresetName { get { return CurrentActivePreset.PresetName; } }

    public override string[] GetPresetsNames()
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

    protected T CurrentActivePreset
    {
        get
        {
            if (CurrentActivePresetIndex >= presets.Count)
            {
#if UNITY_EDITOR
                Debug.LogError("Preset of index " + CurrentActivePresetIndex + " not found in " + typeof(T).ToString());
#endif
                return default;
            }

            return presets[CurrentActivePresetIndex];
        }
    }
}