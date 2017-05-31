using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorthTileCollision : MonoBehaviour {

	//Reference the parent object of the colliders
	public GameObject levelGenerator;
	//Reference the transform of the LevelGenerator GameObject
	public Transform genPosition;
	//Reference the size of the tiles
	public float tileSize = 15f;
	//Reference the GameObject used to spawn tiles
	public GameObject spawner;
	//Reference the transform of the previous GameObject
	private Transform spawnerTransform;
	//Reference the sample tile used when instantiating - to be replaced with an array of tiles
	public GameObject sampleTile;

	void Start(){
		//Assign the transform of the LevelGenerator to genPosition
		genPosition = levelGenerator.gameObject.transform;
		//Assign the spawner GameObject in the scene to spawner
		spawner = GameObject.FindGameObjectWithTag ("Spawner");
		//Assign the transform of spawner to spawnerTransform
		spawnerTransform = spawner.GetComponent<Transform> ();
	}

	void OnTriggerEnter(Collider player){
		if (player.gameObject.tag == "Player") {
			//What direction is the player moving? - debug tells you
			Debug.Log ("North");
			//Move the spawner GameObject to the middle of the next row
			spawnerTransform.position = new Vector3 (spawnerTransform.position.x + tileSize, spawnerTransform.position.y, spawnerTransform.position.z);
			//Move the parent of the colliders to the next row
			genPosition.position = new Vector3 (genPosition.position.x + tileSize, genPosition.position.y, genPosition.position.z);
			//Spawn a tile at the centre of the spawner
			Instantiate (sampleTile, spawnerTransform.position, Quaternion.identity);
			//Spawn a tile next to the first tile
			Instantiate(sampleTile, new Vector3 (spawnerTransform.position.x, spawnerTransform.position.y, spawnerTransform.position.z + tileSize), Quaternion.identity);
			//Spawn a tile on the opposite side of the first tile
			Instantiate(sampleTile, new Vector3 (spawnerTransform.position.x, spawnerTransform.position.y, spawnerTransform.position.z - tileSize), Quaternion.identity);
			//Move the spawner to the centre of the tile that the player is currently on
			spawnerTransform.localPosition = Vector3.zero;
		}
	}
}