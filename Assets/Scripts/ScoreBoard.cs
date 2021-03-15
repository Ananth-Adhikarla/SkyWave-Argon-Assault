using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    
    Text scoreText;
    public int score = 0;
    public int highScore = 0;
    public string HighScoreKey = "HighScore";
    public string CurrentScoreKey = "CurrentScore";

    // Start is called before the first frame update
    void Start()
    {

        scoreText = GetComponent<Text>();
        score = PlayerPrefs.GetInt(CurrentScoreKey);


    }
    void Update()
    {
        if(score < 0)
        {
            score = 0;
        }
        int count = SceneManager.GetActiveScene().buildIndex;
        if (count == 3)
        {
            scoreText.text = "High Score: " + score;
        }
        else
        {
            scoreText.text = " " + score;
        }
        
    }
    public void ScoreHit(int ScoreIncrease)
    {
        score = score + ScoreIncrease;
        PlayerPrefs.SetInt(CurrentScoreKey, score);
    }

    public void Reset()
    {
        score = 0;
    }

    public void HighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(HighScoreKey, score);
            PlayerPrefs.Save();
        }
    }

}
