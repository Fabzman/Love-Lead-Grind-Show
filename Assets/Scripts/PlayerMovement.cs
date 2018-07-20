using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float Speed;
    private Rigidbody rigidBody;
    private Vector3 movement;
    private Vector3 moveSpeed;

	// At the beginning call the Rigidbody on the Player
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
	
	// When it updates detect what direction is being pressed on the keyboard
	void Update ()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveSpeed = movement * Speed;
    }

    //Updates for physics (i think)
    void FixedUpdate()
    {
        rigidBody.velocity = moveSpeed;
    }
}
