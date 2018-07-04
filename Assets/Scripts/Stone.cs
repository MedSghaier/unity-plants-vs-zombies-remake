using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

        void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.GetComponent<Attacker>())
        {
            anim.SetTrigger("UnderAttackTrigger");
        }
    }
}
