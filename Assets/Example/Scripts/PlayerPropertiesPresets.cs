using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerPropertiesPresets", menuName = "Scriptable Object/Properties Presets/PlayerPropertiesPresets", order = 0)]
public class PlayerPropertiesPresets : PropertiesPresets<PlayerPropertiesPresetsPreset>
{
    public int Speed { get { return CurrentActivePreset.Speed; } }
}

[Serializable]
public class PlayerPropertiesPresetsPreset : Preset
{
    [SerializeField] private int speed = 0;

    public int Speed { get { return speed; } }
}