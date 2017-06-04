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
	//Reference the GameObject used to remove tiles
	public GameObject tileRemover;
	//Reference the transform of the previous GameObject
	public Transform removerTransform;
	//Reference the size of the collider on the tileRemover
	public float removeSize;

	void Start(){
		genPosition = levelGenerator.gameObject.transform;
		spawner = GameObject.FindGameObjectWithTag ("Spawner");
		spawnerTransform = spawner.GetComponent<Transform> ();
		//Assign the tileRemover GameObject in the scene to tileRemover
		tileRemover = GameObject.FindGameObjectWithTag("Remover");
		//Assign the transform of tileRemover to removerTransform
		removerTransform = tileRemover.GetComponent<Transform>();
		//Assign a value to removeSize
		removeSize = tileSize + 5;
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
			//Move the tileRemover so that it is opposite to the spawner
			removerTransform.position = new Vector3 (removerTransform.position.x + (removeSize * 2), removerTransform.position.y - 1, removerTransform.position.z);
			//Start waiting co-routine;
			StartCoroutine (Waiting ());
		}
	}

	IEnumerator Waiting(){
		yield return new WaitForSeconds (0.0000001f);
		//Move tileRemover to the centre of the LevelGenerator GameObject
		removerTransform.localPosition = new Vector3 (0, 1, 0);
	}
}
