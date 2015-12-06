using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door : MonoBehaviour {
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

	public void toggleVisibility(bool visible, Collider hit){

		if (hit.name != "House") {
			House.image.enabled = visible;
			House.GetComponentInChildren<Text> ().enabled = visible;
		}
		if (hit.name != "Cemetery") {
			Cemetery.image.enabled = visible;
			Cemetery.GetComponentInChildren<Text> ().enabled = visible;
		}
		if (hit.name != "School") {
			School.image.enabled = visible;
			School.GetComponentInChildren<Text> ().enabled = visible;
		}
		if (hit.name != "Hospital Lobby") {
			Hospital_lobby.image.enabled = visible;
			Hospital_lobby.GetComponentInChildren<Text> ().enabled = visible;
		}
	}
}
