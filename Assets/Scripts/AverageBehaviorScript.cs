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
    private Vector3 targetTransform;
    private float playerY;
    private float playerX;
    private float playerZ;

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
        playerX = GameObject.Find("MockPlayer").transform.position.x;
        playerY = GameObject.Find("MockPlayer").transform.position.y;
        playerZ = GameObject.Find("MockPlayer").transform.position.z;

        targetTransform = new Vector3(playerX, 0, playerZ);

        bulletTimer += Time.deltaTime;

        if (bulletTimer > rateOfFire && transform.position.x > playerX + 2)
        {
            Shoot();
            bulletTimer = 0.0f;
        }

        if (transform.position.x > playerX + 2)     //If enemy is on right side of player
        {
            transform.position = Vector3.MoveTowards(transform.position, targetTransform, horizontalSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - exitSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= -50) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }

    }

    private void Shoot()
    {
        Instantiate(averageBullet, transform.position, transform.rotation);
    }
}
