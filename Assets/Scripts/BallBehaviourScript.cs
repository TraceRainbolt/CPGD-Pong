using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviourScript : MonoBehaviour {
    
	public float ymin, ymax;

    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();	//	Initialize the rigidbody variable
        rb.velocity = new Vector2(4, 4);	//	Give the ball an inital velocity
    }

	void FixedUpdate () {
		if(transform.position.y <= ymin || transform.position.y >= ymax) {	//	Check if we hit the top or bottom of screen
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);		//	Reverse y velocity
        }
	}

    void OnTriggerEnter2D(Collider2D other) {
        rb.velocity = new Vector2(-1.1f * rb.velocity.x, rb.velocity.y);	//	Reverse x velocity on collision
    }
}
