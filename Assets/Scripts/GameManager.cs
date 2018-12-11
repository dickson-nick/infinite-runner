
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float RESTART_DELAY = 0.5f;

    public GameObject levelCompleteUI;
    public GameObject levelFailedUI;

    public void LevelComplete()
    {
        if (!gameHasEnded)
        {
            if (PlayerPrefs.GetInt("UnlockedLevel") < SceneManager.GetActiveScene().buildIndex + 1)
                PlayerPrefs.SetInt("UnlockedLevel", SceneManager.GetActiveScene().buildIndex + 1);

            Debug.Log("Level Complete!");
            levelCompleteUI.SetActive(true);
        }
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GameOver()
    {
        if(!gameHasEnded)
        {
            Debug.Log("Game Over!");
            gameHasEnded = true;
            Invoke("DeathScreen", RESTART_DELAY);
        }
        
    }

    void DeathScreen()
    {
        levelFailedUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNext()
    {
        if (!gameHasEnded)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
	
}
