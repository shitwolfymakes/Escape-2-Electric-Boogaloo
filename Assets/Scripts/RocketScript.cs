using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public float bulletSpeed;
    private float playerYtemp;
    private float playerXtemp;
    private float playerZtemp;
    private Vector3 targetTransform;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerYtemp = GameObject.Find("MockPlayer").transform.position.y;
        playerXtemp = GameObject.Find("MockPlayer").transform.position.x;
        playerZtemp = GameObject.Find("MockPlayer").transform.position.z;
        targetTransform = new Vector3(playerXtemp, playerYtemp, playerZtemp);
        gameObject.transform.LookAt(targetTransform);

        transform.position = Vector3.MoveTowards(transform.position, targetTransform, bulletSpeed * Time.deltaTime);
        if (transform.position.x == playerXtemp) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }
    }
}
