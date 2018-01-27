using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {
    public GameObject sagfasdgsfs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            sagfasdgsfs.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sagfasdgsfs.SetActive(false);
        }
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        sagfasdgsfs.SetActive(true);
    //    }
    //}
}
