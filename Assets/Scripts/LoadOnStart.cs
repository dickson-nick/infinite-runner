using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnStart : MonoBehaviour {

    public AudioClip wireless;
    public AudioClip honey;
    public AudioClip wantToKnow;

    // Use this for initialization
    void Awake() {
        // Create Settings if none exist
        if (!PlayerPrefs.HasKey("UnlockedLevel"))
            PlayerPrefs.SetInt("UnlockedLevel", 1);

        if (!PlayerPrefs.HasKey("LeftKeyBind"))
            PlayerPrefs.SetString("LeftKeyBind", "a");

        if (!PlayerPrefs.HasKey("RightKeyBind"))
            PlayerPrefs.SetString("RightKeyBind", "d");

        if (!PlayerPrefs.HasKey("JumpKeyBind"))
            PlayerPrefs.SetString("JumpKeyBind", "space");

        if (!PlayerPrefs.HasKey("MusicVolume"))
            PlayerPrefs.SetFloat("MusicVolume", 1.0f);

        if (!PlayerPrefs.HasKey("EffectsVolume"))
            PlayerPrefs.SetFloat("EffectsVolume", 1.0f);

        if (!PlayerPrefs.HasKey("Soundtrack"))
            PlayerPrefs.SetInt("Soundtrack", 0);

        int soundtrack = PlayerPrefs.GetInt("Soundtrack");
        AudioSource bgMusic = GameObject.Find("Background Music").GetComponent<AudioSource>();

        if (soundtrack == 0)
            bgMusic.clip = wireless;
        else if (soundtrack == 1)
            bgMusic.clip = honey;
        else if (soundtrack == 2)
            bgMusic.clip = wantToKnow;

        bgMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        bgMusic.Play();

        DontDestroyOnLoad(gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        //if (level >= 6 && level <= 8)
        //{
            Debug.Log("Loaded.");
            GameObject.Find("Menu Select Audio").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("EffectsVolume");
        //}
    }
}
