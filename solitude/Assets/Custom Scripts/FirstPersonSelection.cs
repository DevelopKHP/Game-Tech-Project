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
	private bool puzzle1;
	private bool puzzle2;
	private bool puzzle3;
	private bool one_time;
	
	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		puzzle1 = false;
		puzzle2 = false;
		puzzle3 = false;
		one_time = false;
		//default values
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && JPuz.activeSelf == true) { 
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
			if (hit.collider.tag == "Tomb" || hit.collider.tag == "Locker")
			{
				interact.text = "Interact (E)";
			}

			else if (hit.collider.tag == "Teleport")
			{
				if (puzzle1 == true){
					interact.text = "Interact (E)";
				}
			}
				
				else if(hit.collider.tag == "Item")
			{
				if (hit.collider.gameObject.GetComponent<Item>().pickable)
					interact.text = "Pick up (E)";
			}
			else if (hit.collider.tag == "NPC"){
				interact.text = hit.collider.gameObject.GetComponent<npc_script>().name + "\nInteract (E)";
			}
			else if (hit.collider.tag == "Journal"){
				for (int i = 0; i < 5; i++)
				{
					if(gameObject.GetComponent<Inventory>().inventory[i].itemName == "Note")
					{
						interact.text = "Interact (E)";
						break;
					}
				}
			}
			else if (hit.collider.tag == "Bed"){
				if(puzzle2 == true)
				{
					interact.text = "Interact (E)";
				}
			}
			else
			{
				interact.text = "";
			}
		}

		if (Input.GetKeyDown(KeyCode.E)) { //value 0 is left mouse button
			if (Physics.Raycast(r, out hit, rayCastingLength)){
				if ( hit.collider.tag == "Tomb" || hit.collider.tag == "NPC" || hit.collider.tag == "Locker")
				{
					hit.collider.GetComponent<InteractObject>().UpdateObject(hit.collider, interact, gameObject);
				}
				else if (hit.collider.tag == "Teleport")
				{
					if (puzzle1 == true)
					{
						gameObject.GetComponentInParent<FirstPersonController>().enabled = false;
						hit.collider.GetComponent<InteractObject>().UpdateObject(hit.collider, interact, gameObject);
					}
				}
				else if (hit.collider.tag == "Item"){
					if (hit.collider.gameObject.GetComponent<Item>().pickable){
						gameObject.GetComponent<Inventory>().addObject(hit.collider.gameObject);
						hit.collider.gameObject.SetActive(false);
					}
				}
				else if (hit.collider.tag == "Journal"){
					for (int i = 0; i < 5; i++)
					{
						if(gameObject.GetComponent<Inventory>().inventory[i].itemName == "Note")
						{
							hit.collider.GetComponent<InteractObject>().UpdateObject(hit.collider, interact, gameObject);
							break;
						}	
					}
				}
				else if (hit.collider.tag == "Bed"){
					if(puzzle2 == true && one_time == false)
					{
						GameObject flag = new GameObject();
						flag = Instantiate(flag);
						flag.AddComponent<Item>();
						flag.GetComponent<Item>().itemName = "Flag";
						gameObject.GetComponent<Inventory>().addObject(flag);
						one_time = true;
					}
				}
			}
		}
	}
	public void finishedPuzzle(string puzzle){
		if (puzzle == "Rosary") {
			puzzle1 = true;
		}
		if (puzzle == "Journal") {
			puzzle2 = true;
		}
		if (puzzle == "Locker") {
			puzzle3 = true;
		}
	}
}

