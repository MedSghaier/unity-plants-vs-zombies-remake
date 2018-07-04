using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray ;
	private AudioSource audiosource;

	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	void Start (){

		audiosource= GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded (int level)
	{
		AudioClip thisLevelMusic = levelMusicChangeArray [level];
		Debug.Log ("play clip:" + thisLevelMusic);
		if (thisLevelMusic) {
          
            audiosource.clip = thisLevelMusic;
            audiosource.loop = true;
			audiosource.Play();
		}
	}

	public void ChangeVolume (float volume){
	audiosource.volume = volume ;
	}
}
