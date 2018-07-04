using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {


	private GameObject DefendersParent ;
    private StarDisplay strDisplay;

	// Use this for initialization
	void Start () {
        strDisplay = GameObject.FindObjectOfType<StarDisplay>();


        DefendersParent = GameObject.Find ("Defenders");
		if (!DefendersParent ) {
			DefendersParent = new GameObject("Defenders") ;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown ()
	{
       

		Vector2 rawPos = CalculateWorldPointOfMouseClick();
		Vector2 roundedPos = snapToGrid(rawPos);
        //Vector3 pos = new Vector3 (roundedPos.x, roundedPos.y, 0.5f);

        GameObject defender = Button.selectedDefender;

        int defenderCost = defender.GetComponent<Defenders>().starNeeded;
        if (strDisplay.UseStars(defenderCost)==StarDisplay.Status.SUCESS){
            GameObject obj = Instantiate(defender, roundedPos, Quaternion.identity) as GameObject;
            obj.transform.SetParent(DefendersParent.transform);
        }
        else
        {
            Debug.Log("Insufficient Stars to sapw");
        }
    }

	Vector2 snapToGrid (Vector2 rawWorldPos)
	{
		int RoundX = Mathf.RoundToInt (rawWorldPos.x);
		int RoundY = Mathf.RoundToInt (rawWorldPos.y);
		Vector2 SnapedSpaceGrid = new Vector2 (RoundX, RoundY);
		//print(SnapedSpaceGrid);
		return SnapedSpaceGrid;
	}

	Vector2 CalculateWorldPointOfMouseClick ()
	{
		Vector3 clickCord = Input.mousePosition;
		Vector3 ClickCordInWorldPoint = Camera.main.ScreenToWorldPoint (clickCord);
		Vector2 ClicksInWorldPoint = new Vector2 (ClickCordInWorldPoint.x, ClickCordInWorldPoint.y);
		//print(ClicksInWorldPoint);
		return (ClicksInWorldPoint);
	}
}
