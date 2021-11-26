using System.Collections.Generic;
using UnityEngine;

public class PresetsOverridePresetManager : MonoBehaviour
{
    [SerializeField]
    private bool overridePresets;

    [SerializeField]
    private List<PresetsOverridePreset> presetsOverrides;

    private void Awake()
    {
        if (overridePresets)
        {
            OverridePresets();
        }
    }

    private void OverridePresets()
    {
        for (int i = 0; i < presetsOverrides.Count; i++)
        {
            presetsOverrides[i].OverridePresets();
        }
    }
}
