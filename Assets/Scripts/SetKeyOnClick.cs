﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetKeyOnClick : MonoBehaviour {

    public void Awake()
    {
        GameObject.Find("Move Left Button/Text").GetComponent<Text>().text = PlayerPrefs.GetString("LeftKeyBind").ToUpper();
        GameObject.Find("Move Right Button/Text").GetComponent<Text>().text = PlayerPrefs.GetString("RightKeyBind").ToUpper();
        GameObject.Find("Jump Button/Text").GetComponent<Text>().text = PlayerPrefs.GetString("JumpKeyBind").ToUpper();

        GameObject.Find("Music Slider").GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolume");
        GameObject.Find("Effects Slider").GetComponent<Slider>().value = PlayerPrefs.GetFloat("EffectsVolume");
        GameObject.Find("Soundtrack Dropdown").GetComponent<Dropdown>().value = PlayerPrefs.GetInt("Soundtrack");
    }

    public void SetKey(string key)
    {
        StartCoroutine(WaitForKeyDown(key));
    }

    IEnumerator WaitForKeyDown(string key)
    {
        string value = "";
        string gameObjectPath;
        bool keyFound = false;

        do
        {
            foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(vKey))
                {
                    value = vKey.ToString();
                    keyFound = true;
                }
            }
            yield return null;
        } while (!keyFound);

        value = value.ToLower();


        if (key.Equals("LeftKeyBind"))
        {
            gameObjectPath = "Move Left Button/Text";
        }
        else if (key.Equals("RightKeyBind"))
        {
            gameObjectPath = "Move Right Button/Text";
        }
        else
        {
            gameObjectPath = "Jump Button/Text";
        }

        PlayerPrefs.SetString(key, value);
        GameObject.Find(gameObjectPath).GetComponent<Text>().text = value.ToUpper();
        yield return null;
    }
}
