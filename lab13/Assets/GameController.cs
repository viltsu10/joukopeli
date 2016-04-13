using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
	
	private Button banaaniNappi;
	private Button omenaNappi;
	private Button porkkanaNappi;
	private Text teksti;
	private Player alex = new Player();
	private Dictionary<Button,GameItem> linkki = new Dictionary<Button, GameItem> ();
	private List<string> itemTeksti = new List<string> ();

	void Start () {
		


		banaaniNappi = GameObject.Find ("BanaaniButton").GetComponent<Button> ();
		porkkanaNappi = GameObject.Find ("PorkkanaButton").GetComponent<Button> ();
		omenaNappi = GameObject.Find ("OmenaButton").GetComponent<Button> ();
		teksti = GameObject.Find ("TextMyText").GetComponent<Text> ();

		GameItem porkkana = new GameItem ("porkkana");
		GameItem omena = new GameItem ("omena");
		GameItem banaani = new GameItem ("banaani");
		linkki.Add (banaaniNappi, banaani);
		linkki.Add (porkkanaNappi, porkkana);
		linkki.Add (omenaNappi, omena);


		porkkanaNappi.onClick.AddListener (() => { 
			alex.AddItem (porkkana); 
			Teksti();
		}
		);

		omenaNappi.onClick.AddListener (() => { 
			alex.AddItem (omena); 
			Teksti();
		}
		);

		banaaniNappi.onClick.AddListener (() => { 
			alex.AddItem (banaani); 
			Teksti();
		}
		);

		teksti.text = "";

	}

	void Teksti() {
		itemTeksti = alex.GetItemNames ();
		teksti.text += itemTeksti [itemTeksti.Count - 1] + "\n";
	}

}
