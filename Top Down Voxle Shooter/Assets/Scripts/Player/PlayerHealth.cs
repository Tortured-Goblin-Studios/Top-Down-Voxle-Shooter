using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
    private float health;
    public Transform spawnPoint;
    public TextMeshProUGUI healthText;
    public string levelToLoad;

    void Start()
    {
        health = playerHealth;
    }

    private void Update()
    {
        healthText.text = health.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "enemyBullet")
        {
            health-= 1;
            if(health <= 0)
            {
                Respawn();
            }
        }
        if (other.transform.tag == "Explosion")
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
        SceneManager.LoadScene(levelToLoad);

    }
}
