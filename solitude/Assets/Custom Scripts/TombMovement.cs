using UnityEngine;
using System.Collections;

public class TombMovement : MonoBehaviour {

	// Use this for initialization
	private bool flag = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void execute(){
		if (!flag) {
			GetComponent<Transform> ().Translate (-2, 0, 0);
		} else {
			GetComponent<Transform> ().Translate (2, 0, 0);
		}
		flag = !flag;
	}
}
