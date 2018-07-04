using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {


	public GameObject projectile,
	  				  gun ;

    private Animator animator;

	private GameObject projectileParent;
    private  AttackerSpawner spawnerLane; 

	 void Start ()
	{
        animator = GetComponent<Animator>();   
        
         
		projectileParent = GameObject.Find ("projectiles");
		if (!projectileParent ) {
			projectileParent = new GameObject("projectiles") ;
		}

        SetMyLaneSpawner();
        print(spawnerLane);
	}

    void Update() {

        if (isAttackerAheadInLane()) {
            animator.SetBool("isAttacking", true);
        }else
        {
            animator.SetBool("isAttacking", false);

        }
    }

    void SetMyLaneSpawner() {
        AttackerSpawner[] spawners = GameObject.FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spaw in spawners)
        {
            if (spaw.transform.position.y == this.transform.position.y)
            {
                spawnerLane = spaw;
                return;
            }
        }

        Debug.LogError(name + "can't fint spawner in lane");
        

    }

    bool isAttackerAheadInLane() {

        //Exit if no attackers in Lane 

        if(spawnerLane.transform.childCount <= 0)
        {
            return false;

        }

        foreach (Transform attacker in spawnerLane.transform) {
            if (attacker.transform.position.x > transform.position.x) {
                return true;
            }
        }
        //attacker in lane but not ahead 
        return false;
        
    }

    private void Fire () 
	 {
	 GameObject newProjectile = Instantiate(projectile) as GameObject;
	 newProjectile.transform.parent = projectileParent.transform ;
	 newProjectile.transform.position = gun.transform.position;
	 }
}