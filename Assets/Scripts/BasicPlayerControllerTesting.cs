using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class BasicPlayerControllerTesting : MonoBehaviour
{
    public float Speed;
    public GameObject bullet;
    public Transform firePoint;
    public float fireRate;
    public Boundary boundary;

    private float delayFire;
    

    private void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > delayFire)
        {
            Debug.Log("Pew Pew");
            delayFire = Time.time + fireRate;
            Instantiate(bullet, firePoint.position, firePoint.rotation * Quaternion.Euler(0.0f, 90f, 0.0f));
            GetComponent<AudioSource>().Play();
        }
    }

    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * Speed;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
         );
    }
}
