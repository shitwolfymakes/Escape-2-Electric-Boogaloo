using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinterBehavior : MonoBehaviour
{
    public GameObject player; //position of the player will influence movement of AI

    private float playerX;
    private float playerY;

    public float initialSpeed;
    public float targetedSpeed;

    private float targetDistance;
    private Vector2 targetTransform;

    private int readyToCharge;
    
    // Start is called before the first frame update
    void Start()
    {
        playerY = GameObject.Find("MockPlayer").transform.position.y;
        targetDistance = Random.Range(3f, 10f);
        targetTransform = new Vector2(targetDistance, playerY);
     
        
    }

    // Update is called once per frame
    void Update()
    {
       //playerX = GameObject.Find("Player").transform.position.x;

        if (readyToCharge == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetTransform, initialSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - targetedSpeed * Time.deltaTime, transform.position.y);
        }
        if (Vector2.Distance(transform.position, targetTransform) < 0.1f)
        {
            readyToCharge = 1;
        }
        
       
        
    }
}
