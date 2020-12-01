using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{

    public AudioMixer mixer;

    public Slider MasterSlider, MusicSlider, SfxSlider;
    public AudioSource sfxLoop;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("MasterVol"))
        {
            mixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("MasterVol"));
            MasterSlider.value = PlayerPrefs.GetFloat("MasterVol");
        }
        if (PlayerPrefs.HasKey("MusicVol"))
        {
            mixer.SetFloat("MusicVol", PlayerPrefs.GetFloat("MusicVol"));
            MusicSlider.value = PlayerPrefs.GetFloat("MusicVol");
        }
        if (PlayerPrefs.HasKey("SFXVol"))
        {
            mixer.SetFloat("SFXVol", PlayerPrefs.GetFloat("SFXVol"));
            SfxSlider.value = PlayerPrefs.GetFloat("SFXVol");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterVolume()
    {
        mixer.SetFloat("MasterVol", MasterSlider.value);
        PlayerPrefs.SetFloat("MasterVol", MasterSlider.value);
    }

    public void SetMusicVolume()
    {
        mixer.SetFloat("MusicVol", MusicSlider.value);
        PlayerPrefs.SetFloat("MusicVol", MusicSlider.value);

    }

    public void SetSFXVolume()
    {
        mixer.SetFloat("SFXVol", SfxSlider.value);
        PlayerPrefs.SetFloat("SFXVol", SfxSlider.value);
    }
    public void PlaySFXLoop()
    {
        sfxLoop.Play();
    }
    public void StopSFXLoop()
    {
        sfxLoop.Stop();
    }
}
