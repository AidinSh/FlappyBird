﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour {
    
    public void startTheScene ()
    {
        SceneManager.LoadScene("Main");
    }

	}

