using UnityEngine;
using UnityEditor;

public class SettingsManager
{
    public PlayerPrefs pref;

    public void test()
    {
        PlayerPrefs.SetInt("Test", 1);
    }
}