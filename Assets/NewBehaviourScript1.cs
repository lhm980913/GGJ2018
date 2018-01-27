using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    public bool sahfsaf = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(sahfsaf)
        this.transform.Rotate(new Vector3(0, 0, 1f));
    }
}
