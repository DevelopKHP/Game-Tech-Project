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


	public void UpdateObject(Collider HitTag, Text interact, GameObject player)
	{
		Debug.Log ("IN");
		if (HitTag.tag == "Tomb") {
			GetComponent <TombMovement> ().execute (player);
		} 
		else if (HitTag.tag == "Teleport") {
			MenuScreen (HitTag);
		} 
		else if (HitTag.tag == "Locker") {
			HitTag.gameObject.GetComponent<LockerTP>().TP();
		} 
		else if (HitTag.tag == "Journal") {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			player.gameObject.GetComponentInParent<FirstPersonController> ().enabled = false;
			fJournal.gameObject.SetActive (true);
		} 
		else if (HitTag.tag == "NPC") {
			GetComponent<AudioSource> ().Play ();
		} 
	}

	public void MenuScreen(Collider hit){
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		gameObject.GetComponent<Door> ().toggleVisibility (true, hit);

	}
}