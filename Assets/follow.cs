﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Rigidbody2D player;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(player.position.x, player.position.y, -2f);
	}
}
