using UnityEngine;

public class DataLoaderSample : MonoBehaviour
{
    [SerializeField]
    private EnemyPropertiesPresets enemyPropertiesPresets = null;

    [SerializeField]
    private PlayerPropertiesPresets playerPropertiesPresets = null;

    private void Start()
    {
#if UNITY_EDITOR
        Debug.Log("Enemy preset name: " + enemyPropertiesPresets.CurrentActivePresetName);
        Debug.Log("Enemy attack damage: " + enemyPropertiesPresets.AttackDamage);

        Debug.Log("Player preset name: " + playerPropertiesPresets.CurrentActivePresetName);
        Debug.Log("Player speed: " + playerPropertiesPresets.Speed);
#endif
    }
}