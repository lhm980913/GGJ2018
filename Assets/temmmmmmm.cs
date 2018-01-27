using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temmmmmmm : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        this.transform.rotation = Quaternion.Euler(0, 0, 60-150*(1-water.tem / 4));
	}
}
