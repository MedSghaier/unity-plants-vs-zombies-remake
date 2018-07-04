using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed ; 
	public float damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D target) 
	{
		GameObject attkr = target.gameObject ;
		Health health = attkr.GetComponent<Health> ();


		if (!attkr.GetComponent<Attacker> ()) {
			return;
		}
		if (attkr.GetComponent<Attacker>() && health) {
			health.DealDaamage(damage);
			Destroy(gameObject);
		}
	}


}
