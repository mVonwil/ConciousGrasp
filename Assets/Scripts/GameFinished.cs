using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFinished : MonoBehaviour {

	public CanvasGroup endSlate;

	void Start(){
		endSlate = GameObject.FindGameObjectWithTag ("EndSlate").GetComponent<CanvasGroup> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player")
			endSlate.alpha += Time.deltaTime;
	}
}
