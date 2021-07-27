using UnityEngine;

public class DataLoaderSample : MonoBehaviour
{
    [SerializeField] private EnemyPropertiesPresets enemyPropertiesPresets = null;

    void Start()
    {
#if UNITY_EDITOR
        Debug.Log("Preset name: " + enemyPropertiesPresets.CurrentActivePresetName);
        Debug.Log("Enemy attack damage: " + enemyPropertiesPresets.AttackDamage);
#endif
    }
}