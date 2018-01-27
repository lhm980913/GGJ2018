using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCtr : MonoBehaviour {
    private Vector3 self;
    public GameObject zhuanpan;
    private Vector3 its;
    // Use this for initialization
    private void OnEnable()
    {
        
    }
    void Start () {
        self = transform.position;
        its = zhuanpan.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(self.x, self.y + 9.5f, self.z), 5 * Time.deltaTime);
        later();
        //zhuanpan.transform.position = Vector3.MoveTowards(zhuanpan.transform.position, new Vector3(its.x, its.y + 5, its.z), 5 * Time.deltaTime);
    }
    private void OnDisable()
    {
        transform.position = self;
    }
    void later()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.8f);
        zhuanpan.transform.position = Vector3.MoveTowards(zhuanpan.transform.position, new Vector3(its.x, its.y + 6, its.z), 5 * Time.deltaTime);
    }
}
