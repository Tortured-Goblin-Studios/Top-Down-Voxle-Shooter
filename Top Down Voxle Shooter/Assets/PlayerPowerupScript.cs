using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerupScript : MonoBehaviour
{
    private int randomChoice;
    public PlayerMovement playerMovementScript;
    public PlayerHealth playerHealthScript;
    public GameObject sheild;
    public Transform player;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Powerup")
        {
            randomChoice = Random.Range(1, 5);

            if (randomChoice == 2)
            {
                playerMovementScript.speed += 10;
            }
            else if(randomChoice == 3)
            {
                playerHealthScript.currentHealth += 5;
            }
            else
            {
                Instantiate(sheild, player.position, player.rotation);
            }
        }
    }
}
