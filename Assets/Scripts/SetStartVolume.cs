using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {
	private MusicManager musicManager ;
	private float volume ;
	
	// Use this for initialization
	void Start ()
	{

		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		volume = PlayerPrefManager.GetMasterVolume ();
		if (musicManager) {
			musicManager.ChangeVolume (volume);
		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
