using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMusicSliderChanged : MonoBehaviour {

	public void SliderChanged(float sliderValue)
    {
        GameObject.Find("Background Music").GetComponent<AudioSource>().volume = sliderValue;

        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}
