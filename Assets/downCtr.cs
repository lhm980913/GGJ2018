using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downCtr : MonoBehaviour {
    private Vector3 self;
    public GameObject ice;
	// Use this for initialization
	void Start () {
        self = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(ice.active == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(self.x, self.y , self.z), 8 * Time.deltaTime);
        }
	}
}
