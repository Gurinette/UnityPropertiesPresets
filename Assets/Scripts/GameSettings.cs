using System.Collections.Generic;
using UnityEngine;

public abstract class GameSettings<T> : ScriptableObject where T : Preset
{
    /// <summary>
    /// Enum to easily toggle between presets.
    /// </summary>
    public enum ActivePreset
    {
        FirstPreset = 0,
        LastPreset = 1
    }

    [SerializeField] private ActivePreset activePreset = ActivePreset.FirstPreset;
    [SerializeField] protected List<T> presets = null;

    private int CurrentPresetIndex
    {
        get
        {
            switch (activePreset)
            {
                case ActivePreset.FirstPreset:
                    return 0;
                case ActivePreset.LastPreset:
                    return presets.Count - 1;
                default:
                    return 0;
            }
        }
    }

    #region PUBLIC
    public string PresetName { get { return CurrentPreset.PresetName; } }
    #endregion

    #region PROTECTED
    /// <summary>
    /// Returns the current active preset.
    /// </summary>
    protected T CurrentPreset
    {
        get
        {
            if (presets == null || presets.Count == 0)
            {
                Debug.LogError("Preset list is null or empty.");
                return default;
            }
            else if (CurrentPresetIndex >= presets.Count)
            {
                Debug.LogError("Preset of index " + CurrentPresetIndex + " not found in " + typeof(T).ToString());
                return default;
            }

            return presets[CurrentPresetIndex];
        }
    }
    #endregion
}

public abstract class Preset
{
    [SerializeField] private string presetName = "";

    public string PresetName { get { return presetName; } }
}