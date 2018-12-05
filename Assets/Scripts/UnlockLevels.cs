using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevels : MonoBehaviour {

	void Awake () {
        int unlockedLevels = PlayerPrefs.GetInt("UnlockedLevel");

        if (unlockedLevels >= 5)
            GameObject.Find("Level 05 Button").GetComponent<Button>().interactable = true;
        if (unlockedLevels >= 4)
            GameObject.Find("Level 04 Button").GetComponent<Button>().interactable = true;
        if (unlockedLevels >= 3)
            GameObject.Find("Level 03 Button").GetComponent<Button>().interactable = true;
        if (unlockedLevels >= 2)
            GameObject.Find("Level 02 Button").GetComponent<Button>().interactable = true;
        if (unlockedLevels >= 1)
            GameObject.Find("Level 01 Button").GetComponent<Button>().interactable = true;
    }
}
