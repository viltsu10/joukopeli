using System;


public class GameItem
{
	private string itemName;

	public GameItem (string name)
	{
		itemName = name;
	}

	public string GetItemName (){
		return this.itemName;
	}
}


