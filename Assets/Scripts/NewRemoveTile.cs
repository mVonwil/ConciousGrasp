using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRemoveTile : MonoBehaviour {

	void OnTriggerEnter(Collider remove){
		if (remove.gameObject.tag == "Land") {
			Debug.Log ("enter" + Time.frameCount + this.gameObject.name);
			Destroy (remove.gameObject);
			transform.localPosition = new Vector3 (0, 20, 0);
		}
	}

}
