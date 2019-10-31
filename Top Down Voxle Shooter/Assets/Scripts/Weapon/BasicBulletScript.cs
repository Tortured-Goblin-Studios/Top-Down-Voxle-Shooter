using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBulletScript : MonoBehaviour
{
    public Rigidbody bulletRB;
    public float moveSpeed;

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * moveSpeed, Space.World);
    }
}
