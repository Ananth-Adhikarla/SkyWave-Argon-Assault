using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore : MonoBehaviour
{
    Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        
        scoreText = GetComponent<Text>();
        score = PlayerPrefs.GetInt("HighScore");
        scoreText.text = "High Score: " + score;
       
    }

}
