using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeleteBulletOnImpact : MonoBehaviour
{
    public float destroyTime;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "PlayerSheild")
        {
            Destroy(gameObject);
        }
    }
}
