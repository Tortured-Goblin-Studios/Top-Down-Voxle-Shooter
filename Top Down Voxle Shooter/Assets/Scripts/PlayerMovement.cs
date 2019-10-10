using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    void Update() 
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        transform.Translate(inputX * Time.deltaTime * speed, 0, inputZ * Time.deltaTime * speed);
    }
}
