﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public PlatformEffector2D pl;

    public float speed_steam;
    static public float tem = 4;
    int a;
    public GameObject[] steam;
    float ttime = 0;
    float rate = 0;
    public float whide;
    int i = 0;
    int n = 1;
    public float lenth;

    bool iswater = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        a = (int)tem;
        ttime += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            tem--;

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            tem++;

        }
        if (tem == 5) tem = 4;
        if (tem == 0) tem = 1;

        switch (a)
        {
            case 1:
                {
                    beeice();
                }
                break;
            case 2:
                {
                    beeice();
                }
                break;
            case 3:
                {
                    beewater();
                }
                break;
            case 4:
                {
                    beesteam();

                
                }
                break;
        }
	}
    void beeice()
    {
        bool iswater = false;
    }
    void beesteam()
    {
        bool iswater = false;
        if (ttime>rate)
        {
           
            rate = ttime + speed_steam;

            Instantiate(steam[i], new Vector3(this.transform.position.x - whide + Random.Range(0, whide), this.transform.position.y-3),new Quaternion());
            Instantiate(steam[n], new Vector3(this.transform.position.x - whide + Random.Range(0, whide), this.transform.position.y-2), new Quaternion());
            i++;n++;
            if (i == 3) i = 0;
            if (n == 3) n = 0;
        }
    }   
    void beewater()
    {
        iswater = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(iswater)
        {
            if(collision.tag=="Player")
            {

                Destroy(collision.gameObject);
            }
        }
    }

}
