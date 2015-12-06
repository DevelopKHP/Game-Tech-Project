using UnityEngine;
using System.Collections;

public class open : MonoBehaviour {

	// Use this for initialization
	private int numLosses;
	public bool opened;
	void Start () {
		opened = false;
		numLosses = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void closeAll(){		
		if (GameObject.Find ("locker1").GetComponent<open> ().opened == true) {
			GameObject.Find ("locker1").transform.Translate ((float)-0.55, (float)0.0, (float).5);
			GameObject.Find ("locker1").transform.Rotate (0, -90, 0);
		}
		if(GameObject.Find ("locker2").GetComponent<open> ().opened == true){		
			GameObject.Find ("locker2").transform.Translate ((float)-0.55, (float)0.0, (float).5);
			GameObject.Find ("locker2").transform.Rotate (0, -90, 0);
		}
		if(GameObject.Find ("locker3").GetComponent<open> ().opened == true){
			GameObject.Find ("locker3").transform.Translate ((float)-0.55, (float)0.0, (float).5);
			GameObject.Find ("locker3").transform.Rotate (0, -90, 0);
		}
		if(GameObject.Find ("locker4").GetComponent<open> ().opened == true){
			GameObject.Find ("locker4").transform.Translate ((float)-0.55, (float)0.0, (float).5);
			GameObject.Find ("locker4").transform.Rotate (0, -90, 0);
		}
		GameObject wallLeft = GameObject.Find ("w1");
		GameObject wallRight = GameObject.Find ("w2");
		GameObject wallBottom = GameObject.Find ("w3");
		GameObject player = GameObject.Find ("FPSController");

		GameObject.Find ("locker1").GetComponent<open> ().opened = false;	
		GameObject.Find ("locker2").GetComponent<open> ().opened = false;		
		GameObject.Find ("locker3").GetComponent<open> ().opened = false;		
		GameObject.Find ("locker4").GetComponent<open> ().opened = false;
		wallLeft.transform.Translate((float)0.0,(float)0.0,(float)1.0);
		wallBottom.transform.Translate((float)0.0,(float)0.0,(float)-1.0);
		wallRight.transform.Translate((float)0.0,(float)0.0,(float)1.0);

		//w2 is bottom wall w1 is left and w3 right

		if (wallLeft.transform.position.x >= player.transform.position.x) {
			player.transform.Translate((float)1.0, (float)0.0, (float) 0.0);
		}
		if (wallBottom.transform.position.z >= player.transform.position.z) {
			player.transform.Translate((float)0.0, (float)0.0, (float) 1.0);
		}
		if (wallRight.transform.position.x <= player.transform.position.x) {
			player.transform.Translate((float)-1.0, (float)0.0, (float) 0.0);
		}

		if(numLosses > 2){
			//Exit Scene
		}
		numLosses++;
	}
}
