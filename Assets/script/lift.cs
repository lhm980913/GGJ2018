using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour {
    public GameObject wheel;
    private int i = 0;
    private Vector3 local;
	// Use this for initialization
	void Start () {
        local = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        if(wheel.GetComponent<NewBehaviourScript>().enabled ==true)
        {
            transform.position = Vector3.MoveTowards(transform.position,new Vector3( local.x, local.y + 5.0f, local.z), 5.0f * Time.fixedDeltaTime);
        }
        if (wheel.GetComponent<NewBehaviourScript>().enabled == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(local.x, local.y , local.z), 5.0f * Time.fixedDeltaTime);
        }
    }
}
