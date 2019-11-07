using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAI_Move : MonoBehaviour
{
    public Transform player;
    public GameObject explosionEffect;
    public Transform explodePos;

    public int moveRepeat;
    public float waitTimeBeforeMove;
    public float moveSpeed = 7;
    int minDist = 1;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {

 

    }

    public void Move()
    {
        transform.LookAt(player);
        
            if (Vector3.Distance(transform.position, player.position) >= minDist)
            {
                transform.position += transform.forward * moveSpeed * Time.deltaTime;
            }
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(explosionEffect, explodePos.position, explodePos.rotation);
            Destroy(gameObject);
        }
    }
}


