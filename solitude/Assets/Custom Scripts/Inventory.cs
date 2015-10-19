using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	/*
	 * Inventory System is a simple array.
	 * 
	 */
	public Item[] inventory;
	// Use this for initialization
	void Start () {
		inventory = new Item[10];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
