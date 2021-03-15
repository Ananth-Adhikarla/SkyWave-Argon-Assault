using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RemoveScore : MonoBehaviour
{
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        var CurrentScene = SceneManager.GetActiveScene().name;
        print("Current Scene::: " + CurrentScene);

        if(CurrentScene == "Finish Scene")
        {
             scoreText.gameObject.SetActive(false);
        }

    }

}
