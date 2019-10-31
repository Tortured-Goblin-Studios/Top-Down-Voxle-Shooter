using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject[] enemies;

    public Transform[] enemySpawnPoints;

    public float spawnRate;

    void Start() {
        StartCoroutine(StartSpawn());
    }

    void SpawnEnemy() {
        int enemyId = Random.Range(0, enemies.Length);
        int spawnId = Random.Range(0, enemySpawnPoints.Length);

        Instantiate(enemies[enemyId], enemySpawnPoints[spawnId].position, enemySpawnPoints[spawnId].rotation);

        if (spawnRate >= 0.05f)
            spawnRate -= 0.01f;
    }

    IEnumerator StartSpawn() {
        SpawnEnemy();
        yield return new WaitForSeconds(spawnRate);
        StartCoroutine(StartSpawn());
    }
}
