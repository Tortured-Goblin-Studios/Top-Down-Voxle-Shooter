using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float floatHeight  = 1;

    public bool doseFloat;

    private Rigidbody rb;

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        Move();
        Rotate();
    }

    void FixedUpdate() 
    {
        if(doseFloat)
            Hover();

    }

    void Hover()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, floatHeight))
        {
            transform.position = hit.point + new Vector3(0, floatHeight, 0);
            rb.useGravity = false;
        }
        else
        {
            rb.useGravity = true;
        }
    }

    void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        transform.Translate(inputX * Time.deltaTime * speed, 0, inputZ * Time.deltaTime * speed, Space.World);
    }

    void Rotate()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }
}
