using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Sets the Character's speed.
    public float speed = 3.0f;

    // Creates a charcter controller variable.
    CharacterController controller;

	// Asigns the Character Controller component to the variable so that it's functions can be accessed.
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	void Update () {

        // LEFT and RIGHT

        // Moves the player left and right (Taken and modified from https://docs.unity3d.com/ScriptReference/CharacterController.SimpleMove.html)
        // Changes the local position (0, 0, 1) into a direction. (Is my understandin)
        Vector3 right = transform.TransformDirection(Vector3.right);

        // The current speed of the player is the set speed times the Horizontal axis (1 or -1).
        float curSpeed = speed * Input.GetAxis("Horizontal");

        // Moves the character in the right driection times the current speed. If the speed is negitive it will move left.
        controller.SimpleMove(right * curSpeed);


        // JUMP




    }
}
