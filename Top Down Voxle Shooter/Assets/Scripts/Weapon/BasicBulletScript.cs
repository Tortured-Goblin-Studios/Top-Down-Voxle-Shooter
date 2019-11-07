using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBulletScript : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * moveSpeed, Space.World);
    }

    void OnCollisionEnter(Collision col) {
        if(col.transform.GetComponent<ArenaPlayerHealth>()) {
            col.transform.GetComponent<ArenaPlayerHealth>().TakeDamage(1);
        }
    }
}
