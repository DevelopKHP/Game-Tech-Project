using UnityEngine;
using System.Collections;

public class StairTP : MonoBehaviour {

	public string target_level;
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other)
	{

		if (target_level == "HouseDownstairs") {
			player.transform.position = new Vector3 (76, 1, 172);
		}
		else if (target_level == "HouseUpstairs") {
			player.transform.position = new Vector3 (31, 3, 177);
		}
	}
}
