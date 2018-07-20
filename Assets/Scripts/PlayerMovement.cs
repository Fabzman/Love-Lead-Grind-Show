﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float Speed;
    private Rigidbody rigidBody;
    private Vector3 movement;
    private Vector3 moveSpeed;
    private Camera mainCamera;

	// At the beginning call the Rigidbody on the Player and the camera for the ray
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
    }
	
	void Update ()
    {
        // When it updates detect what direction is being pressed on the keyboard
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveSpeed = movement * Speed;

        //Ray being cast from camera to ground, if it detects the ground, the player faces the mouse position
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if (ground.Raycast(cameraRay, out rayLength))
        {
            Vector3 lookSpot = cameraRay.GetPoint(rayLength);
            //just for testing, so i can see the line
            Debug.DrawLine(cameraRay.origin, lookSpot, Color.yellow);
            //this makes the player game object rotate to look at the ray being cast
            transform.LookAt(new Vector3(lookSpot.x, transform.position.y, lookSpot.z));
        }
    }

    //Updates for physics (i think)
    void FixedUpdate()
    {
        rigidBody.velocity = moveSpeed;
    }
}