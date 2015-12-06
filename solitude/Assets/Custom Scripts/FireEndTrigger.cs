using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class FireEndTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj){
		gameObject.GetComponent<ParticleSystemDestroyer> ().enabled = true;

	}
}
