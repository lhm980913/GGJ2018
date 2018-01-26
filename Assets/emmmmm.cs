using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emmmmm : MonoBehaviour {
    public GameObject imgggg;
    public water water;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        imgggg.transform.localScale = new Vector3(1, 1-water.tem/4, 1);

	}
}
