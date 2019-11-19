using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ArenaPlayerHealth : MonoBehaviour {

    public float maxHealth;
    private float currentHealth;

    public TextMeshProUGUI healthText;
    public Image healthBarImage;


    void Start() {
        currentHealth = maxHealth;
    }

    void Update() {
        UpdateHealthUI();

        if(currentHealth <= 0) {
            currentHealth = 0;
            Destroy(gameObject);
        }
    }

    void UpdateHealthUI() {
        healthText.text = "Health: " + currentHealth.ToString();
        healthBarImage.fillAmount = currentHealth / maxHealth;
    }

    public void TakeDamage(float amount) {  
         currentHealth -= amount;
    }
}
