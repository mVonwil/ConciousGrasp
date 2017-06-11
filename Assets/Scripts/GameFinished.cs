using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFinished : MonoBehaviour {

	public CanvasGroup endSlate;
	public GameObject player;
	public bool fadeIn = false;

	void Start(){
		endSlate = GameObject.FindGameObjectWithTag ("EndSlate").GetComponent<CanvasGroup> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update(){
		if (fadeIn == true) {
			endSlate.alpha += (Time.deltaTime / 3);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			fadeIn = true;
			player.SetActive (false);
		}
	}
}
