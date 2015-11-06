﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InteractObject : MonoBehaviour {
	private bool detected;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}


	public void UpdateObject(string HitTag, Text interact, GameObject player)
	{
		if (HitTag == "Tomb") {
			GetComponent <TombMovement> ().execute (player);
		} else if (HitTag == "Teleport") {
			MenuScreen ();
		}
	}

	public void MenuScreen(){
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		gameObject.GetComponent<Door> ().toggleVisibility (true);
	}
}