using UnityEngine;
using System.Collections;

public class StairTP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollision(Collision collision){
		foreach (ContactPoint contact in collision.contacts){
			Debug.Log ("Stairs");
		}
	}	
}
