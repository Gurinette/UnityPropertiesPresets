using UnityEngine;

public class DataLoaderSample : MonoBehaviour
{
    [SerializeField] private EnemySettings enemySettings = null;

    void Start()
    {
        Debug.Log("Preset name: " + enemySettings.PresetName);
        Debug.Log("Enemy attack damage: " + enemySettings.AttackDamage);
    }
}