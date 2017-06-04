using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	public float timeLimit;
	public GameObject lvlGen;
	public GameObject endGame;
	public GameObject sampleWall;
	private GameObject firstWall;
	private GameObject secondWall;
	private GameObject thirdWall;
	public GameObject sampleHouse;
	private GameObject endHouse;

	// Use this for initialization
	void Start () {
		timeLimit = 20;
		endGame = this.gameObject;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		endGame.transform.position = lvlGen.transform.position;
		timeLimit = timeLimit - Time.deltaTime;
		if(timeLimit <= 0){
			SpawnWalls ();
			lvlGen.SetActive (false);
			timeLimit = Mathf.Infinity;
		}
	}

	void SpawnWalls(){
		firstWall = Instantiate (sampleWall, new Vector3(0, 3, 0), Quaternion.Euler(0, 90, 0));
		firstWall.transform.parent = endGame.transform;
		firstWall.transform.localPosition = new Vector3 (23, 2.51f, 0);
		secondWall = Instantiate (sampleWall, new Vector3(0, 3, 0), Quaternion.Euler(0, 90, 0));
		secondWall.transform.parent = endGame.transform;
		secondWall.transform.localPosition = new Vector3 (-23, 2.51f, 0);
		thirdWall = Instantiate (sampleWall, new Vector3(0, 3, 0), Quaternion.Euler(0, 0, 0));
		thirdWall.transform.parent = endGame.transform;
		thirdWall.transform.localPosition = new Vector3 (0, 2.51f, 23);
		endHouse = Instantiate (sampleHouse, new Vector3(0, 0, 0), Quaternion.Euler(0, 180, 0));
		endHouse.transform.parent = endGame.transform;
		endHouse.transform.localPosition = new Vector3 (0, 0, 0);
	}
}
