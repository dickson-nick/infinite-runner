using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

    public void LoadScene(int level)
    {
        if (level != -1)
        {
            SceneManager.LoadScene(level);
        }
        else
        {
            PlayerPrefs.SetInt("UnlockedLevel", 1);

            GameObject.Find("Canvas").GetComponent<UnlockLevels>().Invoke("Awake", 0);
        }
    }
}
