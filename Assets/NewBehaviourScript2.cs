using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour {
    public NewBehaviourScript1 NewBehaviourScript1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(NewBehaviourScript1.sahfsaf)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y-1, this.transform.position. z);
        }
	}
}
