using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBulletScript : MonoBehaviour
{
    public Rigidbody bulletRB;
    public float moveSpeed;

    void Start()
    {
        bulletRB.AddForce(transform.forward * moveSpeed);
    }
}
