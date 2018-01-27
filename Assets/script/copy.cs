using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copy : MonoBehaviour {

    public Rigidbody2D water;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(water);
            Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water); Instantiate(water);
        }


	}
}
