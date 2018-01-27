using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {
    public int a;
    public NewBehaviourScript NewBehaviourScript;
    public NewBehaviourScript1 NewBehaviourScript1;
    public GameObject w1;
    public GameObject w2;
    public GameObject[] ice;
    private bool isIce = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        a = (int)water.tem;
        switch(a)
        {
            case 4:
                {
                    beeair();
                }
                break;
            case 3:
                {
                    beewater();
                }
                break;
            case 2:
                {
                    beeice();
                }
                break;
            case 1:
                {
                    beeice();
                }
                break;
        }
	}
    void beeair()
    {
        ice[0].SetActive(false);
        ice[1].SetActive(false);
        ice[2].SetActive(false);
        w1.SetActive(false);
        w2.SetActive(false);
        NewBehaviourScript.zhuanzzzzz = false;
        NewBehaviourScript1.sahfsaf = false;

    }
    void beewater()
    {
        isIce = true;
        ice[0].SetActive(false);
        ice[1].SetActive(false);
        ice[2].SetActive(false);
        w1.SetActive(true);
        w2.SetActive(true);
        NewBehaviourScript.zhuanzzzzz = true;
        NewBehaviourScript1.sahfsaf = true;
    }
    void beeice()
    {
        if(!isIce)
        {
            ice[0].SetActive(true);
            ice[1].SetActive(false);
            ice[2].SetActive(false);
        }
        if(isIce)
        {
            ice[0].SetActive(false);
            ice[1].SetActive(true);
            ice[2].SetActive(true);
        }
        NewBehaviourScript.zhuanzzzzz = false;
        NewBehaviourScript1.sahfsaf = false;

        w1.SetActive(false);
        w2.SetActive(false);
        //启动冰图层 大盘子上升
        

    }

}
