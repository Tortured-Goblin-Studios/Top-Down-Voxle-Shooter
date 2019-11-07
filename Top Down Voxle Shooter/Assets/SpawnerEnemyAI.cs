using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemyAI : MonoBehaviour
{
    int MoveSpeed = -3;
    int MaxDist = 30;

    public float moveSpeed;
    public float enemySpawnDelay;

    private Transform Player;
    private Rigidbody self;
    public Transform spawnPoint;

    public GameObject[] enemies;

    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        self = GetComponent<Rigidbody>();
        StartCoroutine(SpawnEnemy());
    }

    void Update()
    {
        transform.LookAt(Player);;
        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
            self.AddForce(transform.forward * moveSpeed);
        }
    }

    IEnumerator SpawnEnemy()
    {
        int spawnID = Random.Range(0, enemies.Length);
        Instantiate(enemies[spawnID], spawnPoint.position, spawnPoint.rotation);
        yield return new WaitForSeconds(enemySpawnDelay);
        StartCoroutine(SpawnEnemy());
    }
}
