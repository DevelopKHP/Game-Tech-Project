using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InteractObject : MonoBehaviour {
	private bool detected;
	public Text interact;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}


	public void UpdateObject(string HitTag)
	{
		if (HitTag == "Tomb") {
			GetComponent <TombMovement> ().execute ();
		} else if (HitTag == "Teleport") {
			Application.LoadLevel ("HouseA");
		} else {
		}
	}



}
