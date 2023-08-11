using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager> {
  public Sound[] musicSounds, sfxSounds;
  public AudioSource musicSource, sfxSource;

  private void Awake() {
    DontDestroyOnLoad(gameObject);
  }

  private void Start() {
    PlayMusic("BackGroundMusic");
  }

  public void PlayMusic(string name) {
    Sound s = Array.Find(musicSounds, x => x.name == name);

    if (s == null) {
      Debug.Log("Sound Not Found");
    }
    else {
      musicSource.clip = s.clip;
      musicSource.Play();
    }
  }
  
  public void PlaySfx(string name) {
    Sound s = Array.Find(sfxSounds, x => x.name == name);

    if (s == null) {
      Debug.Log("Sound Not Found");
    }
    else {
      sfxSource.clip = s.clip;
      sfxSource.Play();
    }
  }

  public void ToggleMusic() {
    musicSource.mute = !musicSource.mute;
  }
  
  public void ToggleSFX() {
    sfxSource.mute = !sfxSource.mute;
  }

  public void MusicVolume(float volume) {
    musicSource.volume = volume;
  }

  public void SfxVolume(float volumn) {
    sfxSource.volume = volumn;
  }
}