using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinterBulletScript : MonoBehaviour
{
    public int bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - bulletSpeed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= -20) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }
    }
}
