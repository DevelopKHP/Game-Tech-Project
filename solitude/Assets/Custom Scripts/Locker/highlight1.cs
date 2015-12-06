using UnityEngine;
using System.Collections;

public class highlight1 : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (!GameObject.Find ("locker1").GetComponent<open> ().opened == true){ 
			GameObject.Find ("locker1").transform.Rotate (0, 90, 0);
			GameObject.Find ("locker1").transform.Translate ((float)0.55, (float)0.0, (float)-.5);
		}
			GameObject.Find ("locker1").GetComponent<open> ().opened = true;
	}
}
