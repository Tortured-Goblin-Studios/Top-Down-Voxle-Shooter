using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBulletOnImpact : MonoBehaviour
{
    public float destroyTime;
    private float delay = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        delay += Time.deltaTime;
        if(delay <= 0)
        {
            Destroy(gameObject);
        }
    }
}
