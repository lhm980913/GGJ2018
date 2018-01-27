using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulingbuling : MonoBehaviour {
    float t = 0;
    public float max, min;
   public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Mathf.Lerp(min, max, t));
        t = t + speed * Time.deltaTime;
        if (t > 1) speed = -0.5f;
        if (t < 0) speed = 0.5f;
    }
}
