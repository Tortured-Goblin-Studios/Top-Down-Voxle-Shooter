using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int numberOfEnemies;
    public GameObject[] enemyToSpawn;
    public Transform spawnPoint;

    public float spawnDelay;
    private float currentSpawnDelay;

    void Start()
    {
        currentSpawnDelay = 0;
    }

    void Update()
    {
        currentSpawnDelay += Time.deltaTime;
        if (currentSpawnDelay > spawnDelay)
        {
            SpawnEnemies();
        }
    }

   

    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            int spawnID = Random.Range(0, enemyToSpawn.Length);
            Instantiate(enemyToSpawn[spawnID], spawnPoint.position, spawnPoint.rotation);
            currentSpawnDelay = 0;
        }
    }
}
