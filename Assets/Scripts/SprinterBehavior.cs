using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinterBehavior : MonoBehaviour
{
    private float playerX;
    private float playerY;
    private float playerZ;

    public float initialSpeed;
    public float targetedSpeed;
    public float rateOfFire = .1f;

    private float targetDistance;
    private Vector3 targetTransform;

    private int readyToCharge;
    private float bulletTimer;

    public GameObject sprinterBullet;

    // Start is called before the first frame update
    void Start()
    {
        targetDistance = Random.Range(0f, 10f);
        readyToCharge = 0;
        bulletTimer = .49f;
    }

    // Update is called once per frame
    void Update()
    {

        if (readyToCharge == 0)
        {
            playerX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
            playerY = GameObject.FindGameObjectWithTag("Player").transform.position.y;
            playerZ = GameObject.FindGameObjectWithTag("Player").transform.position.z;

            targetTransform = new Vector3(targetDistance, playerY, playerZ);
            transform.position = Vector3.MoveTowards(transform.position, targetTransform, initialSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - targetedSpeed * Time.deltaTime, transform.position.y, transform.position.z);
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
        if (Vector3.Distance(transform.position, targetTransform) < 0.1f)
        {
            readyToCharge = 1;
        }
    }
}
