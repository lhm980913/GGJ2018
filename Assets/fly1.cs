using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly1 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (water.tem == 4|| water.tem == 3)
        {
            if (collision.tag == "Player")
            {
                collision.GetComponent<Rigidbody2D>().gravityScale = 0;
                collision.transform.position += new Vector3(0, 4 * Time.deltaTime);
                collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0.1f));
            }
        }
        else collision.GetComponent<Rigidbody2D>().gravityScale = 8;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (water.tem == 4|| water.tem == 3)
        {
            if (collision.tag == "Player")
            {
                //collision.transform.position+= new Vector3(0, 2*Time.deltaTime);
                collision.GetComponent<Rigidbody2D>().gravityScale = 8;
            }
        }
    }
}
