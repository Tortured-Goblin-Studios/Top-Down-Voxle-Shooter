using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int numberOfEnemies;
    public GameObject enemyToSpawn;
    public Transform spawnPoint;

    public float spawnDelay;
    private float currentSpawnDelay;

    void Start()
    {
        spawnDelay = currentSpawnDelay;
    }

    void Update()
    {
        currentSpawnDelay -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            SpawnEnemies();
        }
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Instantiate(enemyToSpawn, spawnPoint.position, spawnPoint.rotation);
            currentSpawnDelay = spawnDelay;
        }
    }
}
