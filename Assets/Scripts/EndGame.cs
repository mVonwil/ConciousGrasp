using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	PlayerMovement playerMovement;

	public float timeLimit;
	public GameObject lvlGen;
	public GameObject fog;
	public GameObject endGame;
	public GameObject wall;
	private GameObject firstWall;
	private GameObject secondWall;
	private GameObject thirdWall;
	public GameObject house;
	private GameObject endHouse;
	public GameObject orb;
	public bool gameEnded = false;
	public bool onEndTile = false;
	public bool runOnce = false;

	// Use this for initialization
	void Start () {
		timeLimit = 30;
		endGame = this.gameObject;
		playerMovement = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Cursor.visible = false;
		endGame.transform.position = lvlGen.transform.position;
		timeLimit = timeLimit - Time.deltaTime;
		if(timeLimit <= 0)
			gameEnded = true;
		if (onEndTile == true && runOnce == false) {
			SpawnWalls ();
			lvlGen.SetActive (false);
			fog.SetActive (false);
			orb = GameObject.FindGameObjectWithTag ("Light Orb");
			Destroy (orb);
			playerMovement.playerAudio.Stop ();
			runOnce = true;
		}
		if (Input.GetKey (KeyCode.Escape))
			Application.Quit ();
	}

	void SpawnWalls(){
		firstWall = Instantiate (wall, new Vector3(0, 3, 0), Quaternion.Euler(0, 90, 0));
		firstWall.transform.parent = endGame.transform;
		firstWall.transform.localPosition = new Vector3 (22, 0, 21.25f);
		secondWall = Instantiate (wall, new Vector3(0, 3, 0), Quaternion.Euler(0, 90, 0));
		secondWall.transform.parent = endGame.transform;
		secondWall.transform.localPosition = new Vector3 (-22, 0, 21.25f);
		thirdWall = Instantiate (wall, new Vector3(0, 3, 0), Quaternion.Euler(0, 0, 0));
		thirdWall.transform.parent = endGame.transform;
		thirdWall.transform.localPosition = new Vector3 (-21.25f, 0, 22);
		endHouse = Instantiate (house, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
		endHouse.transform.parent = endGame.transform;
		endHouse.transform.localPosition = new Vector3 (0.5f, -1, -28);
	}
}
