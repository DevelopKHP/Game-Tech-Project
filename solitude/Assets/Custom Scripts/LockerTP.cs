using UnityEngine;
using System.Collections;

public class LockerTP : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TP(){
		player.transform.position = new Vector3 (20, 5, 14);
	}
}
