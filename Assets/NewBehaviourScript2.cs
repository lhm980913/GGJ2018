using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour {
    public NewBehaviourScript1 NewBehaviourScript1;
	// Use this for initialization
    public float  speeddddddd;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(NewBehaviourScript1.sahfsaf)
        {

            if (this.transform.position.y < 127.3)
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+speeddddddd, this.transform.position. z);
            
                
        }
        else
            if (this.transform.position.y > 116)
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - speeddddddd, this.transform.position.z);

    }
}
