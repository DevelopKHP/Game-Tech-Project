using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Teleport : MonoBehaviour {
	public string target_level;
	public GameObject player;
	public GameObject canvas;
	public GameObject items;
	public Button House;
	public Button Hospital_lobby;
	public Button Cemetery;
	public Button School;
	public GameObject TP;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void teleport(){
		if (target_level == "House") {
			player.transform.position = new Vector3((float)(0.25),1,(float)(0.35));
		}
		player.transform.position = new Vector3(81,2,162);
		player.gameObject.GetComponentInParent<FirstPersonController>().enabled = true;
		House.image.enabled = false;
		House.GetComponentInChildren<Text> ().enabled = false;
		Hospital_lobby.image.enabled = false;
		Hospital_lobby.GetComponentInChildren<Text> ().enabled = false;
		Cemetery.image.enabled = false;
		Cemetery.GetComponentInChildren<Text> ().enabled = false;
		School.image.enabled = false;
		School.GetComponentInChildren<Text> ().enabled = false;
		DontDestroyOnLoad (player);
		DontDestroyOnLoad (canvas);
		DontDestroyOnLoad (items);
		DontDestroyOnLoad (TP);

	

	}
}
