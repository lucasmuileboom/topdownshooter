using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    private int Score = 0;
    private int highScore;
    public Text scoreText;
    public Text highScoreText;

    void Start ()
    {
        highScore = PlayerPrefs.GetInt("High Score");
        scoreText.text = "Score: " + Score;
        highScoreText.text = "HighScore: " + highScore;
    }
    public void GetScore()
    {
        Score = Score + 5;
        scoreText.text = "Score: " + Score;
        if (highScore < Score)
        {
            highScore = Score;
            highScoreText.text = "HighScore: " + highScore;
            PlayerPrefs.SetInt("High Score", highScore);
        }
    }
}
