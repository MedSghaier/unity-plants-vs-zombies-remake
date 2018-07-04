using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour {

    // used as a tag
    public int starNeeded = 100;

    private StarDisplay stardisplay;

    void Start() {
        stardisplay = FindObjectOfType<StarDisplay>();
    }

    public void AddStars(int amount) {
        stardisplay.AddStars(amount);
    }
}
