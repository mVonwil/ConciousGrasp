using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WestTileCollision : MonoBehaviour {

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
			Debug.Log ("East");
			spawnerTransform.position = new Vector3 (spawnerTransform.position.x, spawnerTransform.position.y, spawnerTransform.position.z + tileSize);
			genPosition.position = new Vector3 (genPosition.position.x, genPosition.position.y, genPosition.position.z + tileSize);
			Instantiate (sampleTile, spawnerTransform.position, Quaternion.identity);
			Instantiate(sampleTile, new Vector3 (spawnerTransform.position.x + tileSize, spawnerTransform.position.y, spawnerTransform.position.z), Quaternion.identity);
			Instantiate(sampleTile, new Vector3 (spawnerTransform.position.x - tileSize, spawnerTransform.position.y, spawnerTransform.position.z), Quaternion.identity);
			spawnerTransform.localPosition = Vector3.zero;
		}
	}
}
