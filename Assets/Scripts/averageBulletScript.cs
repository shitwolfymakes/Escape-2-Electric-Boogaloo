﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class averageBulletScript : MonoBehaviour
{
    public float bulletSpeed;
    private float playerYtemp;
    private float playerXtemp;
    private float playerZtemp;
    private Vector3 targetTransform;


    // Start is called before the first frame update
    void Start()
    {
        playerYtemp = GameObject.Find("MockPlayer").transform.position.y;
        playerXtemp = GameObject.Find("MockPlayer").transform.position.x;
        playerXtemp = GameObject.Find("MockPlayer").transform.position.x;

        targetTransform = new Vector3(playerXtemp - 20, playerYtemp, playerZtemp);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetTransform, bulletSpeed * Time.deltaTime);
        if (transform.position.x <= (playerXtemp - 10)) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }
    }
}
