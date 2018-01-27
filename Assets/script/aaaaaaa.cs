using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaaaaa : MonoBehaviour {
    public GameObject aaaaaaaaaaaaaaaaaaaaaaaaa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(aaaaaaaaaaaaaaaaaaaaaaaaa.transform.position.x-5, aaaaaaaaaaaaaaaaaaaaaaaaa.transform.position.y-2);
	}
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.parent = null;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("EEE");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.parent = gameObject.transform;
        }
    }
}
