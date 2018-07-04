using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour {

    private LevelManager levlManager;

    void Start()
    {
        levlManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<Attacker>())
        {
            levlManager.LoadLevel("03b Lose");
        }
    }
    
}
