using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

	public static GM instance = null;

	public float yMinLive = -10f;

	public Transform spawnPoint;

	public GameObject playerPrefab;

	PlayerCtrl player;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
		else if (instance != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		if (player == null) {
			RespawnPlayer();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RespawnPlayer() {
		Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
	}
}
