using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(((byte)SceneManager.GetActiveScene().buildIndex) + 1);
    }
}
