using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDatabase : MonoBehaviour {

	public GameObject tile1;
	public GameObject tile2;
	public GameObject tile3;
	public GameObject tile4;

	public List<GameObject> tiles = new List<GameObject> ();

	public Vector3 tileRot1 = new Vector3(0, 0, 0);
	public Vector3 tileRot2 = new Vector3(0, 90, 0);
	public Vector3 tileRot3 = new Vector3(0, 180, 0);
	public Vector3 tileRot4 = new Vector3(0, 270, 0);

	public List<Vector3> tileRots = new List<Vector3>();

	void Start(){
		tiles.Add (tile1);
		tiles.Add (tile2);
		tiles.Add (tile3);
		tiles.Add (tile4);

		tileRots.Add (tileRot1);
		tileRots.Add (tileRot2);
		tileRots.Add (tileRot3);
		tileRots.Add (tileRot4);
	}
}
