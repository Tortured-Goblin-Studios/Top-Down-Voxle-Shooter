using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBulletOnImpact : MonoBehaviour
{
    public float destroyTime;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
