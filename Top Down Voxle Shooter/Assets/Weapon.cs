using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet1;
    public Transform blasterPos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet1, blasterPos.position, blasterPos.rotation);
        }
    }
}
