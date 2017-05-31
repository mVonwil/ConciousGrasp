using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthTileCollision : MonoBehaviour {

	public GameObject levelGenerator;
	public Transform genPosition;
	public float tileSize = 15f;
	public GameObject spawner;
	private Transform spawnerTransform;
	public GameObject sampleTile;

	void Start(){
		genPosition = levelGenerator.gameObject.transform;
		spawner = GameObject.FindGameObjectWithTag ("Spawner");
		spawnerTransform = spawner.GetComponent<Transform> ();
	}

	void OnTriggerEnter(Collider player){
		if (player.gameObject.tag == "Player") {
			Debug.Log ("South");
			spawnerTransform.position = new Vector3 (spawnerTransform.position.x - tileSize, spawnerTransform.position.y, spawnerTransform.position.z);
			genPosition.position = new Vector3 (genPosition.position.x - tileSize, genPosition.position.y, genPosition.position.z);
			Instantiate (sampleTile, spawnerTransform.position, Quaternion.identity);
			Instantiate(sampleTile, new Vector3 (spawnerTransform.position.x, spawnerTransform.position.y, spawnerTransform.position.z + tileSize), Quaternion.identity);
			Instantiate(sampleTile, new Vector3 (spawnerTransform.position.x, spawnerTransform.position.y, spawnerTransform.position.z - tileSize), Quaternion.identity);
			spawnerTransform.localPosition = Vector3.zero;
		}
	}
}
