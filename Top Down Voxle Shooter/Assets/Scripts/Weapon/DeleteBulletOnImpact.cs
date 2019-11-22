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

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "PlayerSheild")
        {
            Destroy(gameObject);
        }
    }
}
