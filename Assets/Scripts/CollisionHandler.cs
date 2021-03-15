using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionHandler : MonoBehaviour
{

    [Tooltip("In seconds")][SerializeField] float LevelLoadDelay = 1f;
    [Tooltip("Explosion particle when dying")] [SerializeField] GameObject deathFX = null;
    [Tooltip("Hide Ship on Collission")] [SerializeField] GameObject ship = null;
    private void Start()
    {
        deathFX.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(3);
        }
        else if (other.gameObject.tag == "Friendly")
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            StartDeathSequence();
            deathFX.SetActive(true);
            ship.SetActive(false);
            Invoke("ReloadScene", LevelLoadDelay);
        }
    }

    private void StartDeathSequence()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        SendMessage("OnPlayerDeath");
    }

    private void ReloadScene()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene);
    }

}
