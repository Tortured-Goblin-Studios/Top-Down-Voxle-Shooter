using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyStartHealth;
    private float enemyHealth;
    public Transform enemySpawnPoint;

    void Start()
    {
        enemyHealth = enemyStartHealth;
        //enemySpawnPoint = GameObject.Find("Enemy Spawn Point").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            enemyHealth -= 1;
            Debug.Log("Ding");

            if(enemyHealth <= 0) {
                Destroy(gameObject);
            }

            if (enemyHealth <= 0)
            {
                //Respawn();
            }
        }
    }

    public void Respawn()
    {
        transform.position = enemySpawnPoint.position;
        enemyHealth = enemyStartHealth;
    }
}
