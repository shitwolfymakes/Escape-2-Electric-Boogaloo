using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageBehaviorScript : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float exitSpeed;

    private float maxHeight, minHeight;
    private Vector2 targetTransform;
    private float playerY;
    private float playerX;

    // Start is called before the first frame update
    void Start()
    {
        maxHeight = 5;          //Adjust with final playfield size. Look into camera constants. 
        minHeight = -5;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        playerY = GameObject.Find("MockPlayer").transform.position.y;
        playerX = GameObject.Find("MockPlayer").transform.position.x;
        
        targetTransform = new Vector2(playerX, playerY);

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
}
