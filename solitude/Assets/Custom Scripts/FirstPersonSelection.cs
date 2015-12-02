using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using System.Collections;

public class FirstPersonSelection : MonoBehaviour {
	/*
	 * Will lock the mouse to center of the screen.
	 * Implement Ray Casting for detecting and selection
	 * We will add tags to our new objects to determine how they will reat to our selection.
	 */
	public float rayCastingLength;
	public Text interact;
	public GameObject JPuz;



	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		//default values
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) { 
			gameObject.GetComponentInParent<FirstPersonController>().enabled = true;
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			JPuz.SetActive(false);
		}
		RaycastHit hit;
		Ray r = Camera.main.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
		Debug.DrawRay (r.origin, r.direction * rayCastingLength, Color.red); //will see the raycast in scene window
		interact.text = "";
		if (Physics.Raycast(r, out hit, rayCastingLength)){
			if (hit.collider.tag == "Tomb" || hit.collider.tag == "Teleport" || hit.collider.tag == "Journal")
			{
				interact.text = "Interact (E)";
			}

			else if( hit.collider.tag == "Item")
			{
				interact.text = "Pick up (E)";
			}
			else
			{
				interact.text = "";
			}
		}

		if (Input.GetKeyDown(KeyCode.E)) { //value 0 is left mouse button
			if (Physics.Raycast(r, out hit, rayCastingLength)){
				if ( hit.collider.tag == "Tomb" || hit.collider.tag == "Teleport" || hit.collider.tag == "Journal"){
					if(hit.collider.tag == "Teleport"){
						gameObject.GetComponentInParent<FirstPersonController>().enabled = false;
					}
					hit.collider.GetComponent<InteractObject>().UpdateObject(hit.collider.tag, interact, gameObject);
				}
				else if (hit.collider.tag == "Item"){
					gameObject.GetComponent<Inventory>().addObject(hit.collider.gameObject);
					hit.collider.gameObject.SetActive(false);
				}
			}
		}
	}
}

