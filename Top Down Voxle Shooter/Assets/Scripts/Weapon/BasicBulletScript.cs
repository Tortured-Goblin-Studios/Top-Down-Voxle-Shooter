using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBulletScript : MonoBehaviour
{
    public Rigidbody bulletRB;
    public float moveSpeed;

    public bool isArena;

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * moveSpeed, Space.World);
    }

    void OnCollisionEnter(Collision col) {
        Debug.Log("BulletHit");
        if(isArena) {
            
            if(col.transform.GetComponent<ArenaPlayerHealth>())
                col.transform.GetComponent<ArenaPlayerHealth>().TakeDamage(1);
        }
    }
}
