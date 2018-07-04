using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {


	public GameObject[] AttackerPrefabsArray ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		foreach (GameObject thisAttacker in AttackerPrefabsArray) {
			if (isTimeToSpawn (thisAttacker)) {
				Spawn(thisAttacker);

			}
		}
	}

	bool isTimeToSpawn (GameObject attackerObjct)
	{
		Attacker attacker = attackerObjct.GetComponent<Attacker> ();
		float delay = attacker.seenEverySeconds;
		float spawnsPerSec = 1 / delay;

		if (Time.deltaTime > delay) {
			Debug.LogWarning ("frame rate problem");
		}
		float threshold = spawnsPerSec * Time.deltaTime / 2;
        return (Random.value < threshold);
		
	}

	void Spawn (GameObject obj)
	{
		GameObject myObject = Instantiate (obj) as GameObject;
		myObject.transform.parent = this.transform ;
		myObject.transform.position = transform.position ;
	}
}
