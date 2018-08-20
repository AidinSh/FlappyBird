using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    private bool isDead = false;
    private Rigidbody2D bird;

    public float upForce = 200f;

	void Start ()
    {
        bird = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if ( isDead == false )
        {
           if ( Input.GetKeyDown("space") )
            {
                bird.velocity = Vector2.zero;
                bird.AddForce (new Vector2(0, upForce));
            }
        }
	}
    
    void OnCollisionEnter2D ()
    {
        isDead = true;

    }
   
}
