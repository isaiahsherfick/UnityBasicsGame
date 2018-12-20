using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	//Declare rb to make modifications to physics
	public Rigidbody rb;

	//in c# you need to include an f at the end of the value here to signify that it's a float
	public float depthForce = 2000f;

	public float horizontalForce = 2000f;

	public float verticalForce = 2000f;

	void Start()
	{
		//This needs to be here today because Unity has changed its scripting since the tutorial came out
		rb = GetComponent<Rigidbody>();
	}



    	// Update is called once per frame
	// use FixedUpdate() instead of Update() here when dealing with physics inside the function
	// Except we use Update() because it's user input related
    	void Update()
    	{

		//multiply everything by Time.deltaTime to normalize the rate of everything despite framerate
		//disparities between systems

		if (Input.GetKey("d"))
		{
			rb.AddForce(horizontalForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey("a"))
		{
			rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey("w"))
		{
			rb.AddForce(0, 0, depthForce * Time.deltaTime);
		}

		if (Input.GetKey("s"))
		{
			rb.AddForce(0, 0, -depthForce * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.Space))
		{
			rb.AddForce(0, verticalForce * Time.deltaTime, 0);
		}

		if(Input.GetKey(KeyCode.LeftShift))
		{
			rb.AddForce(0, -verticalForce * Time.deltaTime, 0);
		}

    	}
}
