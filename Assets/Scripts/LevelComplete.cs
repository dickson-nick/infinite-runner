using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel()
    {
        FindObjectOfType<GameManager>().LoadNext();
    }
    
    public void MainMenu()
    {
        FindObjectOfType<GameManager>().MainMenu();
    }

    public void RetryLevel()
    {
        FindObjectOfType<GameManager>().Restart();
    }
}
