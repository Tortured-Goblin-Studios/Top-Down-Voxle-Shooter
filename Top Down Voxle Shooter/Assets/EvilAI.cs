using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilAI : MonoBehaviour
{
    public Transform Player;
    public GameObject enemyBullet;
    public Transform blasterPos;

    int MoveSpeed = 1;
    int MaxDist = 1000;
    int MinDist = 1;
    float enemyDelay = 1;
    float enemyCurrentDelay;

    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.LookAt(Player);
        enemyCurrentDelay -= Time.deltaTime;
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
            if(enemyCurrentDelay <= 0)
            {
                Instantiate(enemyBullet, blasterPos.position, blasterPos.rotation);
                enemyCurrentDelay = enemyDelay;
            }
        }
    }
}
