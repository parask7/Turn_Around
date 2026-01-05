using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public Transform player;

    public int currentLevel = 1;
    public int enemiesPerLevel = 10;
    public float spawnRadius = 2f; // spread enemies

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        int enemyCount = currentLevel * enemiesPerLevel;

        for (int i = 0; i < enemyCount; i++)
        {
            Transform spawnPoint = spawnPoints[i % spawnPoints.Length];

            Vector3 randomOffset = new Vector3(
                Random.Range(-spawnRadius, spawnRadius),
                0,
                Random.Range(-spawnRadius, spawnRadius)
            );

            Vector3 spawnPosition = spawnPoint.position + randomOffset;

            GameObject enemy = Instantiate(
                enemyPrefab,
                spawnPosition,
                spawnPoint.rotation
            );

            EnemyAI ai = enemy.GetComponent<EnemyAI>();
            ai.player = player;
        }
    }
}
