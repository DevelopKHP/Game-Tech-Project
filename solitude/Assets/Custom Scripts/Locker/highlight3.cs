using UnityEngine;
using System.Collections;

public class highlight3 : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		if (GameObject.Find ("locker2").GetComponent<open> ().opened == true) {
			if(!GameObject.Find ("locker3").GetComponent<open> ().opened == true){
				GameObject.Find ("locker3").transform.Rotate(0,90,0);
				GameObject.Find ("locker3").transform.Translate ((float)0.55, (float)0.0, (float)-.5);
			}
			GameObject.Find ("locker3").GetComponent<open> ().opened = true;
		} else {
			GameObject.Find ("locker3").GetComponent<open>().closeAll();
		}
	}

}
