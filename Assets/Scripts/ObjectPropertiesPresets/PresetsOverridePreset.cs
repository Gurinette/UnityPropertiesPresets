using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PresetsOverridePreset", menuName = "Scriptable Object/PresetsOverridePreset", order = 0)]
public class PresetsOverridePreset : ScriptableObject
{
    [SerializeField]
    private List<PropertiesPresetsBase> propertiesPresets;
    public List<PropertiesPresetsBase> PropertiesPresets { get { return propertiesPresets; } }

    [SerializeField]
    [HideInInspector]
    private int[] activePresetIndexesOverride;
    public int[] ActivePresetIndexesOverride { get { return activePresetIndexesOverride; } set { activePresetIndexesOverride = value; } }

    public void OverridePresets()
    {
        if (activePresetIndexesOverride == null || activePresetIndexesOverride.Length == 0)
        {
#if UNITY_EDITOR
            Debug.LogWarning("Properties presets overrides were not set for PresetsPreset " + name);
#endif

            activePresetIndexesOverride = new int[propertiesPresets.Count];

            for (int i = 0; i < propertiesPresets.Count; i++)
            {
                activePresetIndexesOverride[i] = propertiesPresets[i].CurrentActivePresetIndex;
            }
        }

        for (int i = 0; i < propertiesPresets.Count; i++)
        {
            propertiesPresets[i].OverrideActivePresetIndex(activePresetIndexesOverride[i]);
            propertiesPresets[i].SetDontUnloadUnusedAsset(true);
        }
    }
}