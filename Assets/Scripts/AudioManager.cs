using UnityEngine;
using UnityEngine.Audio;
using System;
using System.Linq;
using UnityEngine.UI;

public class AudioManager: MonoBehaviour {
	public Sound[] sounds;
	public Text soundT = null; 
	bool isPlayed = true;

	// Use this for initialization
	void Start () {
		if (isPlayed) {
			foreach (var src in FindObjectsOfType <AudioSource>()) 
			{
				src.Play();
			}
		}
		foreach (Sound s in sounds) {
			s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
		}
	}

	void Awake() {
		isPlayed = PlayerPrefs.GetInt ("sound", 1) == 1;
		if(!isPlayed)
			soundT.text = "Music OFF";
	}

	
	public void Play (string name)
	{
		if (!isPlayed)
			return;
		Sound s = sounds.FirstOrDefault(sound => sound.name == name);
		if (s == null)
			return;
		s.source.Play ();
	}

	public void Sound() {
		if (isPlayed) {
			soundT.text = "Music OFF";
			foreach (var src in FindObjectsOfType <AudioSource>()) {
				src.mute = true;
			}
			PlayerPrefs.SetInt ("sound", 0);
			isPlayed = false;
		} else {
			soundT.text = "Music ON";
			foreach (var src in FindObjectsOfType <AudioSource>()) {
				src.mute = false;
				src.Play ();
			}
			PlayerPrefs.SetInt ("sound", 1);
			isPlayed = true;
		}

	}
}
