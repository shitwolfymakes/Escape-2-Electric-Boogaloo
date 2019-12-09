using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinterBullet : MonoBehaviour
{
    public int bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - (bulletSpeed * Time.deltaTime), 0f, transform.position.y);

        if (transform.position.x <= -20) //REPLACE WITH CAMERA MIN 
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            Debug.Log("NOT IMPLEMENTED YET");
        }
    }
}
