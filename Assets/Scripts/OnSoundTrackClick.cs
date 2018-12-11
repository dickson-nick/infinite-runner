using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnSoundTrackClick : MonoBehaviour {

    public AudioClip wireless;
    public AudioClip honey;
    public AudioClip wantToKnow;

	public void SoundTrackChanged()
    {
        int soundtrack = GameObject.Find("Soundtrack Dropdown").GetComponent<Dropdown>().value;
        AudioSource backgroundMusic = GameObject.Find("Background Music").GetComponent<AudioSource>();

        if (soundtrack != PlayerPrefs.GetInt("Soundtrack")) {
            if (soundtrack == 0)
            {
                backgroundMusic.clip = wireless;
                PlayerPrefs.SetInt("Soundtrack", 0);
            }
            else if (soundtrack == 1)
            {
                backgroundMusic.clip = honey;
                PlayerPrefs.SetInt("Soundtrack", 1);
            }
            else if (soundtrack == 2)
            {
                backgroundMusic.clip = wantToKnow;
                PlayerPrefs.SetInt("Soundtrack", 2);
            }

            backgroundMusic.Play();
        }
    }
}
