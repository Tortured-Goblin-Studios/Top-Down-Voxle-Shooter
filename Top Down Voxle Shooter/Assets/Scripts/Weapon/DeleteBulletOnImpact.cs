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
        int ricChance = Random.Range(0, 2);

        switch(ricChance) {
            case 0:
                break;
            case 1:
                Destroy(gameObject);
                break;
        }
    }
}
