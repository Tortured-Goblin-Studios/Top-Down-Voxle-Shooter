﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScattershotEnemAI : MonoBehaviour
{
    public Transform Player;

    int MoveSpeed = 2;
    int MinDist = 3;

    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
    }
}
