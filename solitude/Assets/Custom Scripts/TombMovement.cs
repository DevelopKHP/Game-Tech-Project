using UnityEngine;
using System.Collections;

public class TombMovement : MonoBehaviour {
	public AudioClip voice;
	// Use this for initialization
	private bool flag = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void execute(GameObject player){
		/*
		if (!flag) {
			GetComponent<Transform> ().Translate (-2, 0, 0);
		} else {
			GetComponent<Transform> ().Translate (2, 0, 0);
		}
		flag = !flag;
		*/
		player.GetComponentInParent<AudioSource> ().clip = voice;
		player.GetComponentInParent<AudioSource> ().Play ();
	}
}
