using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

      public enum Status {SUCESS, FAILLURE };

    private Text starText;
    private int stars = 100;

	// Use this for initialization
	void Start () {
        starText = GetComponent<Text>();
        starText.text = stars.ToString();
    }


    public void AddStars(int amount) {
        stars += amount;
        starText.text = stars.ToString();
    }


    public Status UseStars(int amount)
    {
        if (stars > amount)
        {
            stars -= amount;
            starText.text = stars.ToString();
            return Status.SUCESS;
        }
        return  Status.FAILLURE;
    }

}
