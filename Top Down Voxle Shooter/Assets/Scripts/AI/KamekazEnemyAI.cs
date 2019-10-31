using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamekazEnemyAI : MonoBehaviour
{
    public Transform Player;
    public GameObject explosionEffect;
    public Transform explodePos;

    int MoveSpeed = 7;
    int MinDist = 1;

    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Instantiate(explosionEffect, explodePos.position, explodePos.rotation);
            Destroy(gameObject);
        }
    }
}
