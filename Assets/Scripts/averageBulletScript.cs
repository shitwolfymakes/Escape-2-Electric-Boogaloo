using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class averageBulletScript : MonoBehaviour
{
    public float bulletSpeed;
    private float playerYtemp;
    private float playerXtemp;
    private Vector2 targetTransform;

    
    // Start is called before the first frame update
    void Start()
    {
        playerYtemp = GameObject.Find("MockPlayer").transform.position.y;
        playerXtemp = GameObject.Find("MockPlayer").transform.position.x;
        targetTransform = new Vector2(playerXtemp - 20, playerYtemp);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetTransform, bulletSpeed * Time.deltaTime);
        if (transform.position.x <= -20) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }
    }
}
