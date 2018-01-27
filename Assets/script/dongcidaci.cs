using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dongcidaci : MonoBehaviour {
    public float x, y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (water.tem == 4)
        {
            this.transform.position = new Vector3(this.transform.position.x + x, this.transform.position.y + y);
            if (x > 0 && y > 0) x = -x;
            else
            if (x < 0 && y > 0) y = -y;
            else
            if (x < 0 && y < 0) x = -x;
            else
            if (x > 0 && y < 0) y = -y;
        }
        if (water.tem == 3)
        {
            this.transform.position = new Vector3(this.transform.position.x + x/2, this.transform.position.y + y/2);
            if (x > 0 && y > 0) x = -x;
            else
            if (x < 0 && y > 0) y = -y;
            else
            if (x < 0 && y < 0) x = -x;
            else
            if (x > 0 && y < 0) y = -y;
        }

    }
}
