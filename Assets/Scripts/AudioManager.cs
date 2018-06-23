using UnityEngine;
using UnityEngine.Audio;
using System;
using System.Linq;
public class AudioManager: MonoBehaviour {
	public Sound[] sounds;
	// Use this for initialization
	void Start () {
		foreach (Sound s in sounds) {
			s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
		}
	}
	
	public void Play (string name)
	{
		Sound s = sounds.FirstOrDefault(sound => sound.name == name);
		if (s == null)
			return;
		s.source.Play ();
	}
}
