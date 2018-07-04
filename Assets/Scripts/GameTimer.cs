using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameTimer : MonoBehaviour {

    public float GameTime;

    private LevelManager levlManager;
    private AudioSource audioSource;
    private Slider slider;
    private bool isLevelOver = false;
    private GameObject WinLabel;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        audioSource = GetComponent<AudioSource>();
        levlManager = GameObject.FindObjectOfType<LevelManager>();
        WinLabel = GameObject.Find("You Win");
        WinLabel.SetActive(false);
        if (!WinLabel)
        {
            Debug.LogWarning("win not found");
        }
	}
	
	// Update is called once per frame
	void Update () {
        float delay = 1 / GameTime;
        float ttm = delay * Time.deltaTime; // we can use Time.timeSinceLevelLoad
        
        slider.value += ttm;

        if(Time.timeSinceLevelLoad >= GameTime && !isLevelOver)
        {
            isLevelOver = true;
            audioSource.Play();
            WinLabel.SetActive(true);
            Invoke("LoadNextLevel", audioSource.clip.length);
        }
	}

    void LoadNextLevel()
    {
        levlManager.LoadNextLevel();
    }
    
}
