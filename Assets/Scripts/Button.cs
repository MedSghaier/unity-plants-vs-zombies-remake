using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	private Button[] ButtonArray ; 
	private SpriteRenderer sp ;

	public static GameObject selectedDefender ;
	public GameObject defenderPref ; 
	 
	// Use this for initialization
	void Start () {
		ButtonArray = GameObject.FindObjectsOfType<Button>();
		sp= GetComponent<SpriteRenderer>();
		sp.color = Color.grey;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown ()
	{	
		foreach (Button thisButton in ButtonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.grey;
		}
		this.GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defenderPref ; 
		//print(selectedDefender);
	}




}
