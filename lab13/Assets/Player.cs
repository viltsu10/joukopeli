using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {

	private List  <GameItem> itemInventory = new List<GameItem>();

	public Player () {
		
	}

	public void AddItem (GameItem item) {
		itemInventory.Add (item);
	}

	public List<string> GetItemNames() {

		List<string> itemNames = new List<string> ();

		foreach (GameItem item in itemInventory) {
			itemNames.Add (item.GetItemName());
		}
		return itemNames;
	}


}
