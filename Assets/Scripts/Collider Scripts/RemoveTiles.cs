using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTiles : MonoBehaviour {

	void OnTriggerEnter(Collider remove){
		if (remove.gameObject.tag == "Remover") {
			Destroy (this.gameObject);
			Debug.Log ("Removed Tile");
		}
	}
}
