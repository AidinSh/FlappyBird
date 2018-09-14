using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingSky : MonoBehaviour {

    private Rigidbody2D ground;

	void Start ()
    {
        ground = GetComponent<Rigidbody2D> ();
        ground.velocity = new Vector2(-gameControl.instance.scrollSpeed , 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if ( gameControl.instance.gameOver == true )
        {
            ground.velocity = Vector2.zero;
        }
	}
}
