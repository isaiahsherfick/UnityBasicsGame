using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement playerMovement;

	public Rigidbody rb;

	//overriding a function that is called every time an object collides with the player
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Obstacle")
		{
			Debug.Log("Player has collided with an Obstacle");
			playerMovement.enabled = false;
			rb.useGravity = false;
		}
	}

}
