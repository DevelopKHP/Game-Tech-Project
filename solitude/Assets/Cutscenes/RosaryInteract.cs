using UnityEngine;
using System.Collections;

public class RosaryInteract : MonoBehaviour {
	//Actors
	public GameObject Player;
	//Triggers
	public GameObject trigger;
	//Clips
	public AudioClip clip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayScene(GameObject player){
		Player.GetComponent<AudioSource> ().clip = clip;
		Player.GetComponent<AudioSource> ().Play ();

	}
}
