using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTile : MonoBehaviour {

	public MouseLook mouseLook;
	public EndGame endGame;

	public bool runOnce = false;

	void Start(){
		mouseLook = GameObject.FindGameObjectWithTag ("PlayerCamera").GetComponent<MouseLook> ();
		endGame = GameObject.FindGameObjectWithTag ("EndGame").GetComponent<EndGame> ();
	}

	void OnTriggerStay(Collider player){
		if (player.gameObject.tag == "Player" && runOnce == false) {
			if (mouseLook.pitch >= 45) {
				Debug.Log ("On End Tile");
				endGame.onEndTile = true;
				runOnce = true;
			}
		}
	}
}
