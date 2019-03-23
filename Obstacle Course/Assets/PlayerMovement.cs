using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sideForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	//Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
        	rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")) {
        	rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
