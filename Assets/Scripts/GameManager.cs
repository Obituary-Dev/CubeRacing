using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    
    public void CompleteLevel()
    {
        Debug.Log("Level Complete");
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
           Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        // Restarts the current scene (levels)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
