using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Teleport : MonoBehaviour {
	public string target_level;
	public GameObject player;
	public Button House;
	public Button Hospital_lobby;
	public Button Cemetery;
	public Button School;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void teleport(){
		if (target_level == "House") {
			player.transform.position = new Vector3(81,2,162);
		} 
		else if (target_level == "Hospital Lobby") {
			player.transform.position = new Vector3(77,2,416);
		}
		else if (target_level == "Cemetery"){
			player.transform.position = new Vector3(249,2,131);
		}
		else if (target_level == "School"){
			player.transform.position = new Vector3(93,2,458);
		}

		player.gameObject.GetComponentInParent<FirstPersonController>().enabled = true;
		House.image.enabled = false;
		House.GetComponentInChildren<Text> ().enabled = false;
		Hospital_lobby.image.enabled = false;
		Hospital_lobby.GetComponentInChildren<Text> ().enabled = false;
		Cemetery.image.enabled = false;
		Cemetery.GetComponentInChildren<Text> ().enabled = false;
		School.image.enabled = false;
		School.GetComponentInChildren<Text> ().enabled = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

	

	}
}
