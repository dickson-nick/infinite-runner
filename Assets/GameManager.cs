
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float RESTART_DELAY = 1.5f;

    public void EndGame()
    {
        if(!gameHasEnded)
        {
            Debug.Log("GAME OVER");
            gameHasEnded = true;
            Invoke("Restart", RESTART_DELAY);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	
}
