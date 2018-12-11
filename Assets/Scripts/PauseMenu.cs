using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;

    public void OnPauseButtonClick(int button)
    {
        Time.timeScale = 1f;

        if (button == 0) // Continue
        {
            pauseMenu.SetActive(false);
        }
        else if (button == 1) // Restart
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (button == 2) // Quit
        {
            SceneManager.LoadScene(6);
        }
    }
}
