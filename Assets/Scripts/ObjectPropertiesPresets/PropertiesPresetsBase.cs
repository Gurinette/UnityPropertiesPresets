using UnityEngine;

public abstract class PropertiesPresetsBase : ScriptableObject, IPropertiesPresets
{
    [SerializeField]
    [HideInInspector]
    private int currentActivePresetIndex = 0;

    private int? activePresetIndexOverride = null;

    public abstract string CurrentActivePresetName { get; }
    public abstract string[] GetPresetsNames();

    public int CurrentActivePresetIndex { get { return activePresetIndexOverride != null ? activePresetIndexOverride.Value : currentActivePresetIndex; } }

    public void SetActivePresetIndex(int index)
    {
        currentActivePresetIndex = index;
    }

    public void OverrideActivePresetIndex(int index)
    {
        activePresetIndexOverride = index;
    }

    public void SetDontUnloadUnusedAsset(bool dontUnloadUnusedAsset)
    {
        if (dontUnloadUnusedAsset)
        {
            hideFlags = HideFlags.DontUnloadUnusedAsset;
        }
        else
        {
            hideFlags = HideFlags.None;
        }
    }
}

public class Preset
{
    [SerializeField] private string presetName = "";

    public string PresetName { get { return presetName; } }
}