using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {

	private Attacker attacker ;
	private Animator anim;

	// Use this for initialization
	void Start () {

		attacker = GetComponent<Attacker>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		GameObject obj = coll.gameObject;

		if (!obj.GetComponent<Defenders> ()) {
			return;
		}

		if (obj.GetComponent<Stone> ()) {
			anim.SetTrigger ("JumpTrigger");
		} else {
			anim.SetBool ("IsAttacking", true);
			attacker.attack (obj);
		}
	}
}
