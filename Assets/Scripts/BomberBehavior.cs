using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberBehavior : MonoBehaviour
{
    public float verticalSpeed;
    public float horizontalSpeed;
    public float rateOfFire;
    public GameObject rocket;

    private float bulletTimer;
    private float maxHeight, minHeight;
    private Vector2 shootingPosition;

    private float shootingZ;
    private float shootingX;

    // Start is called before the first frame update
    void Start()
    {
        maxHeight = 5;          //Adjust with final playfield size. Look into camera constants. 
        minHeight = -5;
        rateOfFire = 3.0f;
        bulletTimer = 0.0f;
        verticalSpeed = 2;

        //Calculate random position for bomber to stop and move up and down. 
        //Values will need to change once we get size of field
       // shootingX = Random.Range(5f, 20f);
        shootingX = Random.Range(10f, 15f);
        shootingZ = Random.Range(-5f, 5f);
        shootingPosition = new Vector3 (shootingX, 0.0f, shootingZ);


    }

    // Update is called once per frame
    void Update()
    {
        bulletTimer += Time.deltaTime;

        if (bulletTimer > rateOfFire)
        {
            Shoot();
            bulletTimer = 0.0f;
        }

        if (transform.position.x > shootingPosition.x)     //If enemy is on right side of shooting Position
        {
            transform.position = Vector3.MoveTowards(transform.position, shootingPosition, horizontalSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (verticalSpeed * Time.deltaTime));

            if (transform.position.z >= maxHeight || transform.position.z <= minHeight)
            {
                verticalSpeed *= -1;
            }
        }

    }

    private void Shoot()
    {
        Instantiate(rocket, transform.position, Quaternion.Euler(0, 90, 0));

    }
}
