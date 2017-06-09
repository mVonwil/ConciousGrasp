using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDatabase : MonoBehaviour {

	EndGame endGame;

	public GameObject tile1;
	public GameObject tile2;
	public GameObject tile3;
	public GameObject tile4;
	public GameObject tile5;
	public GameObject tile6;
	public GameObject tile7;
	public GameObject tile8;
	public GameObject tile9;
	public GameObject tile10;
	public GameObject tile11;
	public GameObject tile12;
	public GameObject tile13;

	public List<GameObject> tiles = new List<GameObject> ();

	public Vector3 tileRot1 = new Vector3(0, 0, 0);
	public Vector3 tileRot2 = new Vector3(0, 90, 0);
	public Vector3 tileRot3 = new Vector3(0, 180, 0);
	public Vector3 tileRot4 = new Vector3(0, 270, 0);

	public List<Vector3> tileRots = new List<Vector3>();

	public bool runOnce = false;

	void Start(){
		tiles.Add (tile1);
		tiles.Add (tile2);
		tiles.Add (tile3);
		tiles.Add (tile4);
		tiles.Add (tile5);
		tiles.Add (tile6);
		tiles.Add (tile7);
		tiles.Add (tile8);
		tiles.Add (tile9);
		tiles.Add (tile10);
		tiles.Add (tile11);
		tiles.Add (tile12);

		tileRots.Add (tileRot1);
		tileRots.Add (tileRot2);
		tileRots.Add (tileRot3);
		tileRots.Add (tileRot4);

		endGame = GameObject.FindGameObjectWithTag ("EndGame").GetComponent<EndGame> ();
	}

	void Update(){
		if (endGame.gameEnded == true && runOnce == false) {
			tiles.Add (tile13);
			runOnce = true;
		}
	}
}
