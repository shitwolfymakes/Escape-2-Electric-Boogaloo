using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectiles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject firePoint;
    public List<GameObject> vfx = new List<GameObject> ();
    public RotateToMouse rotateToMouse;

    private GameObject laser;
    private GameObject blaster;
    private float timeToFire = 0;
    void Start()
    {
        laser = vfx[0];
        blaster = vfx[1];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / laser.GetComponent<ProjectileMove>().fireRate;
            SpawnVFX(1.0f);
        }
        if (Input.GetMouseButton(1) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / blaster.GetComponent<ProjectileMove>().fireRate;
            SpawnVFX(2.0f);
        }
    }
    void SpawnVFX(float a)
    {
        if(a < 2.0f) { 
            GameObject vfx;
            if(firePoint != null)
            {
                vfx = Instantiate(laser, firePoint.transform.position, Quaternion.identity);
                if(rotateToMouse != null)
                {
                    vfx.transform.localRotation = rotateToMouse.GetRotation();
                }
            }
            else
            {
                Debug.Log("No Fire Point");
            }
        } else if(a > 1.0f)
        {
            GameObject vfx;
            if (firePoint != null)
            {
                vfx = Instantiate(blaster, firePoint.transform.position, Quaternion.identity);
                if (rotateToMouse != null)
                {
                    vfx.transform.localRotation = rotateToMouse.GetRotation();
                }
            }
            else
            {
                Debug.Log("No Fire Point");
            }
        }
    }
    
}
