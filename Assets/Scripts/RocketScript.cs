using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public float bulletSpeed;
    private float playerYtemp;
    private float playerXtemp;
    private Vector2 targetTransform;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        playerYtemp = GameObject.Find("MockPlayer").transform.position.y;
        playerXtemp = GameObject.Find("MockPlayer").transform.position.x;
        targetTransform = new Vector2(playerXtemp, playerYtemp);

        transform.position = Vector2.MoveTowards(transform.position, targetTransform, bulletSpeed * Time.deltaTime);
        if (transform.position.x == playerXtemp) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }
    }
}
