using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheildScript : MonoBehaviour
{
    private GameObject player;
    public int sheildStartHealth;
    private int shieldCurrentHealth;

    void Start()
    {
        shieldCurrentHealth = sheildStartHealth;
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        transform.position = player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "enemyBullet")
        {
            shieldCurrentHealth -= 1;
            if (shieldCurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
        if (other.transform.tag == "Explosion")
        {
            shieldCurrentHealth -= 10;
            if (shieldCurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
