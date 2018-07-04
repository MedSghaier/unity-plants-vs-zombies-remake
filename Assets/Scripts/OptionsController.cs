using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OptionsController : MonoBehaviour {

	public Slider volumeSlider ;
	public Slider difficultySlider ;
	public LevelManager levelManager ;
	private MusicManager musicManger ;

	void Start () {
		musicManger = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefManager.GetMasterVolume(); 
		difficultySlider.value = PlayerPrefManager.GetDifficulty(); 
	}
	
	// Update is called once per frame
	void Update () {
		musicManger.ChangeVolume(volumeSlider.value);
	}

	public void SaveAndExit (){

	PlayerPrefManager.SetMasterVolume (volumeSlider.value);
	PlayerPrefManager.SetDifficulty (difficultySlider.value);
	print (PlayerPrefManager.GetDifficulty());
	levelManager.LoadLevel("01a Start");
	}

	public void SetDefaults ()
	{
		volumeSlider.value = 0.8f;
		difficultySlider.value =2 ;
	}
}
