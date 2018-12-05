using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnStart : MonoBehaviour {

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

        DontDestroyOnLoad(gameObject);
    }
}
