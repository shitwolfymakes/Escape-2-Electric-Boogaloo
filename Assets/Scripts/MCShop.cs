using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCShop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShieldsUP()
    {
        if (GameManager.Money >= 300)
        {
            GameManager.Money -= 300;
            GameManager.totShields++;
            GameManager.Shields = GameManager.totShields;
        }
    }

    public void HullUP()
    {
        if (GameManager.Money >= 300)
        {
            GameManager.Money -= 300;
            GameManager.totHull++;
            GameManager.totHull = GameManager.Hull;
        }
    }

    public void AttackUP()
    {
        if (GameManager.Money >= 1000)
        {
            GameManager.Money -= 1000;
            GameManager.playerFireRate *= (9 / 10);
        }
    }
}
