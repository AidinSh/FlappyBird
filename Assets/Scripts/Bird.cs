using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    private bool isDead = false;
    private Rigidbody2D bird;
    private Animator anim;

    public float upForce = 200f;

	void Start ()
    {
        bird = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if ( isDead == false )
        {
           if ( Input.touchCount > 0 )
            {
                bird.velocity = Vector2.zero;
                bird.AddForce (new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
	}
    
    void OnCollisionEnter2D ()
    {
        isDead = true;
        anim.SetTrigger("Die");
        gameControl.instance.BirdDied();
        bird.velocity = Vector2.zero;
    }
   
}
