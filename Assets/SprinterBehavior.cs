using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinterBehavior : MonoBehaviour
{
    private float playerX;
    private float playerY;

    public float initialSpeed;
    public float targetedSpeed;
    public float rateOfFire;

    private float targetDistance;
    private Vector2 targetTransform;

    private int readyToCharge;
    private float bulletTimer;

    public GameObject sprinterBullet;
    
    // Start is called before the first frame update
    void Start()
    {
      
        targetDistance = Random.Range(0f, 10f);
        readyToCharge = 0;
        bulletTimer = .49f;
        rateOfFire = .25f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (readyToCharge == 0)
        {
            playerX = GameObject.Find("MockPlayer").transform.position.x;
            playerY = GameObject.Find("MockPlayer").transform.position.y;
            targetTransform = new Vector2(targetDistance, playerY);
            transform.position = Vector2.MoveTowards(transform.position, targetTransform, initialSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - targetedSpeed * Time.deltaTime, transform.position.y);
            bulletTimer += Time.deltaTime;

            if (transform.position.x > playerX && bulletTimer > rateOfFire)
            {
                Instantiate(sprinterBullet, transform.position, transform.rotation);
                bulletTimer = 0f;
            }

            if (transform.position.x <= -20) //REPLACE WITH CAMERA MIN 
            {
                Destroy(gameObject);
            }
        }
        if (Vector2.Distance(transform.position, targetTransform) < 0.1f)
        {
            readyToCharge = 1;
        }
        
       
        
    }
}
