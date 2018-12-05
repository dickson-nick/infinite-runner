using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEffectsSliderChanged : MonoBehaviour {

    public void SliderChanged(float sliderValue)
    {
        GameObject.Find("Menu Select Audio").GetComponent<AudioSource>().volume = sliderValue;

        PlayerPrefs.SetFloat("EffectsVolume", sliderValue);
    }
}
