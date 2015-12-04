using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class InteractObject : MonoBehaviour {
	private bool detected;
	public Image fJournal;
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
		} else if (HitTag == "Journal") {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			player.gameObject.GetComponentInParent<FirstPersonController> ().enabled = false;
			fJournal.gameObject.SetActive (true);
		} else if (HitTag == "NPC") {
			GetComponent<AudioSource>().Play();

		}
	}

	public void MenuScreen(){
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		gameObject.GetComponent<Door> ().toggleVisibility (true);
	}
}