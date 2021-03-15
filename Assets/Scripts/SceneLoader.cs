using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public void LoadFirstScene()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(1);
    }
}
