using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArenaPlayerHealth : MonoBehaviour {

    public float maxHealth = 25;
    private float currentHealth;

    public TextMeshProUGUI healthText;
    public Image healthBar;

    void Start() {
        currentHealth = maxHealth;
    }

    void Update() {

        healthBar.fillAmount = currentHealth / maxHealth;
        healthText.text = "Health: " + currentHealth.ToString();

        if(currentHealth <= 0) {
            currentHealth = 0;
            Die();
        }
    }

    public void TakeDamage(float amount) {
        currentHealth -= amount;
    }

    void Die() {
        Destroy(gameObject);
    }
}
