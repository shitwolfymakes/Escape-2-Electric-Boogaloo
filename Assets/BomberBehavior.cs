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

    private float shootingX;
    private float shootingY;

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
        shootingX = Random.Range(5f, 20f);
        shootingY = Random.Range(-5f, 5f);
        shootingPosition = new Vector2(shootingX, shootingY);


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
            transform.position = Vector2.MoveTowards(transform.position, shootingPosition, horizontalSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + (verticalSpeed * Time.deltaTime));

            if (transform.position.y >= maxHeight || transform.position.y <= minHeight)
            {
                verticalSpeed *= -1;
            }
        }

    }

    private void Shoot()
    {
        Instantiate(rocket, transform.position, Quaternion.Euler(0, 0, 90));

    }
}
