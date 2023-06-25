using UnityEngine;
using UnityEngine.UI;

public class ValueHG : MonoBehaviour
{
    public Text score;
    public Text highScore;
    private string hs;
    private int currentScore;
    private int previousHighScore;

    private void FixedUpdate()
    {
        if (highScore.text != "You fell" && highScore.text != "You hit an obstacle")
        {
            int currentScore;
            if (int.TryParse(score.text, out currentScore))
            {
                int previousHighScore = PlayerPrefs.GetInt("Highscore", 0);

                if (currentScore > previousHighScore)
                {
                    hs = currentScore.ToString();
                    PlayerPrefs.SetInt("Highscore", currentScore);
                    highScore.text = hs;
                }
            }
        }
        else
        {
            hs = PlayerPrefs.GetInt("Highscore", 0).ToString();
            highScore.text = hs;
        }
    }

    public void ResetScore() {
        PlayerPrefs.DeleteKey("Highscore");
        highScore.text = "0";
    }
    private void Start()
    {
        currentScore = int.Parse(score.text);
        previousHighScore = PlayerPrefs.GetInt("Highscore", 0);

        if (currentScore > previousHighScore)
        {
            previousHighScore = currentScore;
            PlayerPrefs.SetInt("Highscore", previousHighScore);
        }

        highScore.text = previousHighScore.ToString();
    }
}
