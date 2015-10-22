using UnityEngine;
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


	public void UpdateObject(string HitTag, Text interact)
	{
		if (HitTag == "Tomb") {
			GetComponent <TombMovement> ().execute ();
		} else if (HitTag == "Teleport") {
			MenuScreen ();
		}
	}

	public void MenuScreen(){
		Cursor.lockState = CursorLockMode.None;
	}
}