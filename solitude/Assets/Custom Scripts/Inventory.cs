using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	/*
	 * Inventory System is a simple array.
	 * 
	 */
	public Item[] inventory;
	private int i;
	// Use this for initialization
	void Start () {
		inventory = new Item[10];
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addObject(GameObject item){
		inventory [i] = item.GetComponent<Item>();
		i++;
	}

	public void showItems()
	{
		for (int a = 0; a < 10; a++) {
			inventory [i].gameObject.SetActive(true);
		}
		gameObject.GetComponentInParent<Inventory> ().enabled = false;
	}

	public void exitInventory()
	{
		for (int a = 0; a < 10; a++) {
			inventory [i].gameObject.SetActive(false);
		}
		gameObject.GetComponentInParent<Inventory> ().enabled = true;
	}
}
