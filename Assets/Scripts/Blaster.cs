﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    public float bulletSpeed;
    private Transform rotaion;

    private void Start()
    {
        
        GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }

    private void Update()
    {
        if(transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
}
