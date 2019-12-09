using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySnacks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // +100 for finishing the level, so you can celebrate with beer
        //GameManager.Money += 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrabBeer()
    {
        if (GameManager.Money >= 200)
        {
            GameManager.Money -= 200;
            int beer = Random.Range(0, 1);
            if (beer == 0)
                GameManager.NumHealthBoosts++;
            else if (beer == 1)
                GameManager.NumShieldBoosts++;
        }
    }
}
