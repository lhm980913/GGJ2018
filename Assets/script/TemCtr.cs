using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemCtr : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            water.tem--;

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            water.tem++;

        }
        if (water.tem == 5) water.tem = 4;
        if (water.tem == 0) water.tem = 1;
    }
}
