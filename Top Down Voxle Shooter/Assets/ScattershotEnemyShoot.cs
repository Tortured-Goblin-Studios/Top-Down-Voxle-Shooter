using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScattershotEnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform blasterPos;

    public int ringSize;
    public float shootDelay;

    void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        for (int i = 0; i < ringSize; i++)
        {
            Instantiate(bullet, blasterPos.position, blasterPos.rotation);
            transform.Rotate(0, 5, 0);
        }

        yield return new WaitForSeconds(shootDelay);
        StartCoroutine(Shoot());
    }
}
