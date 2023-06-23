using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject LevelCompleteUI;
    bool gameHasEnded = false;
    float restartDelay = 1f;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", restartDelay);
        }

    }

    public void CompleteLevel()
    {
        LevelCompleteUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
