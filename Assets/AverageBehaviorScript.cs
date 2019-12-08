using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageBehaviorScript : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float exitSpeed;
    public float rateOfFire;
    public GameObject averageBullet;

    private float bulletTimer;
    private float maxHeight, minHeight;
    private Vector2 targetTransform;
    private float playerY;
    private float playerX;

    // Start is called before the first frame update
    void Start()
    {
        maxHeight = 5;          //Adjust with final playfield size. Look into camera constants. 
        minHeight = -5;
        rateOfFire = .75f;
        bulletTimer = 0.0f;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        playerY = GameObject.Find("MockPlayer").transform.position.y;
        playerX = GameObject.Find("MockPlayer").transform.position.x;
        
        targetTransform = new Vector2(playerX, playerY);
        bulletTimer += Time.deltaTime;

        if (bulletTimer > rateOfFire && transform.position.x > playerX + 2)
        {
            Shoot();
            bulletTimer = 0.0f;
        }

        if (transform.position.x > playerX + 2)     //If enemy is on right side of player
        {
            transform.position = Vector2.MoveTowards(transform.position, targetTransform, horizontalSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - exitSpeed * Time.deltaTime, transform.position.y);
        }

        if (transform.position.x <= -20) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }
        
    }

    private void Shoot()
    {
        Instantiate(averageBullet, transform.position, transform.rotation);
         
    }
}
