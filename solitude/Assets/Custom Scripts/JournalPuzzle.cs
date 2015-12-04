using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;

public class JournalPuzzle : MonoBehaviour {
	public Text inputJ;
	public Image fjournal;
	public GameObject fire;
	public GameObject player;
	// Use this for initialization
	void Start () {
		inputJ.text = "";
	}
	
	// Update is called once per frame
	void Update (){
<<<<<<< HEAD
		string answer = inputJ.text.ToLower ();
		if (answer == "look under my bed") {
			if(Input.GetKeyDown(KeyCode.Return)){
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				fjournal.gameObject.SetActive (false);
				fire.SetActive (true);
				player.gameObject.GetComponentInParent<FirstPersonController> ().enabled = true;
				StartCoroutine(MyCoroutine());
			}
=======
		inputJ.text = inputJ.text.ToLower ();
		if (inputJ.text == "look under my bed") {
			Debug.Log("Good Job");
>>>>>>> bd4ed7e3f7c74f93b2a1d0ebe586dbe2c8ea3814
		}
	}

	IEnumerator MyCoroutine()
	{
		yield return new WaitForSeconds(2);
		gameObject.SetActive(false);
	}

}
