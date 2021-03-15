using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameReplay : MonoBehaviour
{
    public void Replay()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(1);
    }
}
