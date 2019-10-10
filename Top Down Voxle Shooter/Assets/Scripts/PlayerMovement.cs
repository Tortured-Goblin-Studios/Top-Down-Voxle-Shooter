using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float floatHeight  = 1;

    private Rigidbody rb;

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        transform.Translate(inputX * Time.deltaTime * speed, 0, inputZ * Time.deltaTime * speed);
    }

    void FixedUpdate() 
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, floatHeight)) 
        {
            transform.position = hit.point + new Vector3(0, floatHeight, 0);
            rb.useGravity = false;
        }
        else 
        {
            rb.useGravity = true;
        }   
    }
}
