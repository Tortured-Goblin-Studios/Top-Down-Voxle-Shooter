using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    private float currentHealth;
    public Transform spawnPoint;
    public TextMeshProUGUI healthText;
    public Image healthBarImage;

    public string levelToLoad;

    void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        UpdateHealthUI();
    }

    void UpdateHealthUI() {
        healthText.text = "Health: " + currentHealth.ToString();
        healthBarImage.fillAmount = currentHealth / maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "enemyBullet")
        {
            currentHealth-= 1;
            if(currentHealth <= 0)
            {
                Respawn();
            }
        }
        if (other.transform.tag == "Explosion")
        {
            currentHealth -= 10;
            if (currentHealth <= 0)
            {
                Respawn();
            }
        }
    }

    public void Respawn()
    {
        transform.position = spawnPoint.position;
        currentHealth = maxHealth;
        SceneManager.LoadScene(levelToLoad);

    }
}
