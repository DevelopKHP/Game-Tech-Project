using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
	/*
	 * Inventory System is a simple array.
	 * 
	 */
	public GameObject panel;
	public Item[] inventory;
	public Button backpack;
	public GameObject Rosary;
	public GameObject Feather;
	public GameObject FoldedFlag;
	public GameObject Note;
	public GameObject Polaroid;
	private bool key;
	int i;
	// Use this for initialization
	void Start () {
		inventory = new Item[5];
		for (int a = 0; a < 5; a++) {
			inventory[a] = null;
		}
		key = true;
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (key == false) {
			if (Input.GetKeyDown (KeyCode.I)) {

				gameObject.GetComponentInParent<FirstPersonController>().enabled = true;
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				panel.SetActive (!panel.activeSelf);
				key = true;
		
			}
		} 
		else {
			if (Input.GetKeyDown (KeyCode.I)) {
				gameObject.GetComponentInParent<FirstPersonController>().enabled = false;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				panel.SetActive (!panel.activeSelf);
				key = false;
				for (int a = 0; a < 10; a++){
					if (inventory[a].itemName == Rosary.name)
					{
						Rosary.SetActive(true);
					}
					else if (inventory[a].itemName == Note.name)
					{
						Note.SetActive (true);
					}
					else if (inventory[a].itemName == FoldedFlag.name)
					{
						FoldedFlag.SetActive (true);
					}
					else if (inventory[a].itemName == Feather.name)
					{
						Feather.SetActive (true);
					}
					else if (inventory[a].itemName == Polaroid.name)
					{
						Polaroid.SetActive (true);
					}
				}
			}

		}
	}
	
	public void addObject(GameObject item){
		inventory [i] = item.GetComponent<Item>();
		if (inventory [i].itemName == "Rosary") {
			puzzleDone();
		}
		i++;
		StartCoroutine (flash ());
	}

	IEnumerator flash()
	{
		backpack.gameObject.SetActive(false);
		yield return new WaitForSeconds(1);
		backpack.gameObject.SetActive (true);
		yield return new WaitForSeconds(1);
		backpack.gameObject.SetActive(false);
		yield return new WaitForSeconds(1);
		backpack.gameObject.SetActive (true);
		yield return new WaitForSeconds(1);
		backpack.gameObject.SetActive(false);
		yield return new WaitForSeconds(1);
		backpack.gameObject.SetActive (true);
		yield return new WaitForSeconds(1);
		backpack.gameObject.SetActive(false);
		yield return new WaitForSeconds(1);
		backpack.gameObject.SetActive (true);
		
	}

	private void puzzleDone()
	{
		gameObject.GetComponentInChildren<FirstPersonSelection>().finishedPuzzle("Rosary");
	}
}
