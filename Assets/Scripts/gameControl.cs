﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameControl : MonoBehaviour {

    public GameObject GameOverText;
    public bool gameOver = false;
    public Text scoreText;
    public static gameControl instance;
    public float scrollSpeed = 1.5f;

    private int score = 0;
	
	void Awake () {
        if ( instance == null )
        {
            instance = this;
        }
        else
        {
            Destroy (gameObject);
        }
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if ( gameOver == true && Input.touchCount > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }	
	}
    public void BirdScored ()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score : " + score.ToString ();
    }
    public void BirdDied()
    {
        GameOverText.SetActive(true);
        gameOver = true;
    }
    public void Back()
    {
        if ( Input.GetKeyDown(KeyCode.Escape) == true)
        {
            SceneManager.LoadScene("Menu Scene");
        }
    }
}
