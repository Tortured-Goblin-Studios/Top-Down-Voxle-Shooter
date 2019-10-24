using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
    private float health;
    public Transform spawnPoint;
    public TextMeshProUGUI healthText;

    void Start()
    {
        health = playerHealth;
    }

    private void Update()
    {
        healthText.text = health.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "enemyBullet")
        {
            health-= 1;
            if(health <= 0)
            {
                Respawn();
            }
        }
        if (collision.transform.tag == "Explosion")
        {
            health -= 10;
            if (health <= 0)
            {
                Respawn();
            }
        }
    }

    public void Respawn()
    {
        transform.position = spawnPoint.position;
        health = playerHealth;
    }
}
