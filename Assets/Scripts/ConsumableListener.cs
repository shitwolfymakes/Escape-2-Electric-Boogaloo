using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && GameManager.NumHealthBoosts > 0)
        {
            gameObject.GetComponent<GameManager>().BoostHull();
        }
        else if (Input.GetKeyDown(KeyCode.P) && GameManager.NumShieldBoosts > 0)
        {
            gameObject.GetComponent<GameManager>().BoostShields();
        }
    }
}
