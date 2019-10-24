using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyStartHealth;
    private float enemyHealth;

    void Start()
    {
        enemyHealth = enemyStartHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            enemyHealth -= 1;
            if (enemyHealth <= 0)
            {
                Die();
            }
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
