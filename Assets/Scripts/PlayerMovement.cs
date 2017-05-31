using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float moveSpeed = 5;
	
	// Update is called once per frame
	void FixedUpdate () {
		Movement();	
	}

	//Move the character with WASD
	void Movement(){
		if (Input.GetKey (KeyCode.W))
			rb.MovePosition (rb.position + Vector3.forward * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			rb.MovePosition (rb.position + Vector3.left * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.S))
			rb.MovePosition (rb.position + Vector3.back * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			rb.MovePosition (rb.position + Vector3.right * moveSpeed * Time.deltaTime);
	}
}
