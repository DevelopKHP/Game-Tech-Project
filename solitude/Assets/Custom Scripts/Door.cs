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

	public void toggleVisibility(bool visible){
		string name = Application.loadedLevelName;

		if (House.name != name) {
			House.image.enabled = visible;
			House.GetComponentInChildren<Text> ().enabled = visible;
		}
		if (Cemetery.name != name) {
			Cemetery.image.enabled = visible;
			Cemetery.GetComponentInChildren<Text> ().enabled = visible;
		}
		if (School.name != name) {
			School.image.enabled = visible;
			School.GetComponentInChildren<Text> ().enabled = visible;
		}
		if (Hospital_lobby.name != name) {
			Hospital_lobby.image.enabled = visible;
			Hospital_lobby.GetComponentInChildren<Text> ().enabled = visible;
		}
	}
}
