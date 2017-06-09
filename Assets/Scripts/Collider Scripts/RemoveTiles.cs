using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTiles : MonoBehaviour {

	public GameObject tileRemover;
	public Transform removerTransform;
	//public TerrainData tileData;

	bool trig = false;

	void Start(){
		tileRemover = GameObject.FindGameObjectWithTag ("Remover");
		removerTransform = tileRemover.transform;
		//tileData = this.gameObject.GetComponent<TerrainData> ();
	}

	void OnTriggerEnter(Collider remove){
		if (remove.gameObject.tag == "Remover" && trig == false) {
			Debug.Log ("enter" + Time.frameCount + this.gameObject.name);
			Destroy (this.gameObject);
			removerTransform.localPosition = new Vector3 (0, 20, 0);
			trig = true;

		}
	}

}
