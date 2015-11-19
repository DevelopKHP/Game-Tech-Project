using UnityEngine;
using System.Collections;

public class StairTP : MonoBehaviour {

	public string target_level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other)
	{
			Application.LoadLevel (target_level);
	}
}
