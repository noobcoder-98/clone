using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<Enemy> enemies;

    private void Update()
    {
        foreach (Enemy enemy in enemies)
        {
            if (!enemy.isSpawned && enemy.spawnerTime <= Time.time)
            {
                Instantiate(enemyPrefab, transform.GetChild(enemy.Spawner).transform);
                enemy.isSpawned = true;
            }
        }
    }
}
