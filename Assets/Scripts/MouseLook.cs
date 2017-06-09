using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public GameObject playerBody;

	public float horizontalSpeed = 2.0f;
	public float verticalSpeed = 2.0f;

	public float yaw = 0.0f;
	public float pitch = 0.0f;
	
	// Update is called once per frame
	void Update () {
		yaw += horizontalSpeed * Input.GetAxis ("Mouse X");
		pitch -= verticalSpeed * Input.GetAxis ("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

		LookLimits ();

		transform.position = new Vector3(playerBody.transform.position.x, playerBody.transform.position.y + 1, playerBody.transform.position.z);
	}

	void LookLimits(){
		if (pitch <= (-70))
			pitch = (-70);
		else if (pitch >= 60)
			pitch = 60;
	}
}
