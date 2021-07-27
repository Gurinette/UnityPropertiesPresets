using System;
using UnityEngine;

// CreateAssetMenu attribute for setting the path to create a scriptable object of this type.
[CreateAssetMenu(fileName = "EnemySettings", menuName = "Scriptable Object/Settings/EnemySettings", order = 0)]
public class EnemySettings : GameSettings<EnemySettingsPreset>
{
    // Access the AttackDamage property through the inherited member CurrentPreset.
    public int AttackDamage { get { return CurrentPreset.AttackDamage; } }
    public AnimationCurve AccelerationCurve { get { return CurrentPreset.AccelerationCurve; } }
}

// Class must be serialized so it would show in the inspector.
[Serializable]
public class EnemySettingsPreset : Preset
{
    [SerializeField] [Range(0, 10)] private int attackDamage = 5;
    [SerializeField] private AnimationCurve accelerationCurve = null;

    public int AttackDamage { get { return attackDamage; } }
    public AnimationCurve AccelerationCurve { get { return accelerationCurve; } }
}