using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class Inventory : MonoBehaviour {
	/*
	 * Inventory System is a simple array.
	 * 
	 */
	public GameObject panel;
	public Item[] inventory;
	public GameObject Rosary;
	public GameObject Feather;
	public GameObject FoldedFlag;
	public GameObject Note;
	private bool flag;
	int i;
	// Use this for initialization
	void Start () {
		inventory = new Item[10];

		flag = true;
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == false) {
			if (Input.GetKeyDown (KeyCode.I)) {

				gameObject.GetComponentInParent<FirstPersonController>().enabled = true;
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				panel.SetActive (!panel.activeSelf);
				flag = true;
		
			}
		} 
		else {
			if (Input.GetKeyDown (KeyCode.I)) {
				gameObject.GetComponentInParent<FirstPersonController>().enabled = false;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				panel.SetActive (!panel.activeSelf);
				flag = false;
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
				}
			}

		}
	}

	public void addObject(GameObject item){
		inventory [i] = item.GetComponent<Item>();
		i++;
	}
}
