using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aboutBackButton : MonoBehaviour {

	public void backToMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
