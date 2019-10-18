using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour {
    public GameObject basePlatform;
	// Use this for initialization
	void Awake () {
		Vector3 currentPosition = Vector3.zero;
	    Transform trans = gameObject.GetComponent<Transform>();
    	for (int i = 0; i< 10; i++) {
	    	Instantiate (basePlatform, currentPosition, trans.rotation);
		    //generate a random position (within a range) to be more fun
		    currentPosition+= new Vector3(0,0,50f);
	    }
    }     

	
	
	// Update is called once per frame
	void Update () {
		
	}
}
