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
	private int i;
	private bool flag;
	// Use this for initialization
	void Start () {
		inventory = new Item[10];
		i = 0;
		flag = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == false) {
			if (Input.GetKeyDown (KeyCode.I)) {
				for (int a = 0; a < 10; a++) {

					//inventory [i].gameObject.SetActive (true);
				}
				gameObject.GetComponentInParent<FirstPersonController>().enabled = true;
				
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				panel.SetActive (!panel.activeSelf);
				flag = true;
			}
		} 
		else {
			if (Input.GetKeyDown (KeyCode.I)) {
				for (int a = 0; a < 10; a++) {
					//inventory [i].gameObject.SetActive (false);
				}
				gameObject.GetComponentInParent<FirstPersonController>().enabled = false;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				panel.SetActive (!panel.activeSelf);
				flag = false;
			}
		}
	}

	public void addObject(GameObject item){
		inventory [i] = item.GetComponent<Item>();
		i++;
	}
}
