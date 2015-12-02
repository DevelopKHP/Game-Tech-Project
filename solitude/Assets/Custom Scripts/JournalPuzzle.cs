using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JournalPuzzle : MonoBehaviour {
	public Text inputJ;
	// Use this for initialization
	void Start () {
		inputJ.text = "";
	}
	
	// Update is called once per frame
	void Update (){
		inputJ.text = inputJ.text.ToLower ();
		if (inputJ.text == "look under my bed") {
			Debug.Log("Good Job");
		}
	}

}
