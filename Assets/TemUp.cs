using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemUp : MonoBehaviour {

    private void OnEnable()
    {
        water.tem++;
        if (water.tem == 5) water.tem = 4;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent < TemUp >().enabled = false;
	}
}
