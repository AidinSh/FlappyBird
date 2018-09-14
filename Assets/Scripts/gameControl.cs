using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameControl : MonoBehaviour {

    public GameObject GameOverText;
    public bool gameOver = false;
    public static gameControl instance;
    public float scrollSpeed = 1.5f;
	
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
	    if ( gameOver == true && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }	
	}
    public void BirdDied()
    {
        GameOverText.SetActive(true);
        gameOver = true;
    }
}
