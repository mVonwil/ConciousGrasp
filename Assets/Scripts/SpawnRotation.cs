using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRotation : MonoBehaviour {

	public TileDatabase tileDb;

	// Use this for initialization
	void Start () {
		tileDb = GameObject.FindGameObjectWithTag ("Database").GetComponent<TileDatabase> ();
		transform.rotation = Quaternion.Euler(tileDb.tileRots[Random.Range(0, tileDb.tileRots.Count)]);
	}
}