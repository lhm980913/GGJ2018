using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steam : MonoBehaviour {
    public GameObject steam_1;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        steam_1.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1*speed);
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="background")
        Destroy(this.gameObject);   
    }
}

