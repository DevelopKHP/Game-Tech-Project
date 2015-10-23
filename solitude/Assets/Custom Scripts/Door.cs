using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door : MonoBehaviour {
	public Button Hospital;
	public Button House;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toggleVisibility(bool visible){
		Hospital.image.enabled = visible;
		Hospital.GetComponentInChildren<Text> ().enabled = visible;
		House.image.enabled = visible;
		House.GetComponentInChildren<Text> ().enabled = visible;
	}
}
