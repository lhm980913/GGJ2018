using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemDown : MonoBehaviour {

    private void OnEnable()
    {
        water.tem--;
        if (water.tem == 0) water.tem = 1;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<TemDown>().enabled = false;
	}
}
