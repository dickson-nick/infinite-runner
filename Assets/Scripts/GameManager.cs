
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float RESTART_DELAY = 1.5f;

    public GameObject levelCompleteUI;

    public void LevelComplete()
    {
        PlayerPrefs.SetInt("UnlockedLevel", SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Level Complete!");
        levelCompleteUI.SetActive(true);
    }

    public void GameOver()
    {
        if(!gameHasEnded)
        {
            Debug.Log("Game Over!");
            gameHasEnded = true;
            Invoke("Restart", RESTART_DELAY);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	
}
