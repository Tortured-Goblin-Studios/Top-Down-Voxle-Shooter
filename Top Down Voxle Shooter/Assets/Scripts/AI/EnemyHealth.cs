using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyStartHealth;
    private float enemyHealth;
    public GameObject explosionEffect;
    public Transform explodePos;

    void Start()
    {
        enemyHealth = enemyStartHealth;
        //enemySpawnPoint = GameObject.Find("Enemy Spawn Point").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Bullet")
        {
            enemyHealth -= 1;
            Debug.Log("Ding");

            if(enemyHealth <= 0) {
                Die();
             }

            if (enemyHealth <= 0)
            {
                //Respawn();
            }
        }
    }

    public void Die()
    {
        Instantiate(explosionEffect, explodePos.position, explodePos.rotation);
        Destroy(gameObject);
    }
}
