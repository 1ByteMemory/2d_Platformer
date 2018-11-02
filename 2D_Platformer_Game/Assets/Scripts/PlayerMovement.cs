using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Definitions
    CharacterController Cc;
    public float playerSpeed = 5f;
    public float gravity = 1f;
    public float jumpHieght = 3f;
    public float jumpPower = 3;

    float airTime;
    float jump;
	
	void Start () {
        airTime = jumpPower;
        // Asigns the character controller component.
        Cc = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        // Everything is in functions to try and keep it neat.
        Move();
    }
    
    void Move()
    {
        // Decrements the airTime while in air.
        if (!Cc.isGrounded)
        {
            airTime -= 1 * Time.deltaTime;
        }

        // Left Right Input (horizontal Input).
        float hInput = Input.GetAxisRaw("Horizontal");


        // Stops the player from jumping too high.
        if (airTime <= 0)
        {
            jump = 0;
        }
        if (airTime > 0)
        {
            jump = Input.GetAxisRaw("Jump");
        }

        // Reset airTime.
        if (Cc.isGrounded) { airTime = jumpPower; }


        // MOVES
        Cc.Move(new Vector3(hInput * playerSpeed * Time.deltaTime, jump * jumpHieght * Time.deltaTime, 0));
        


        // Falling
        if (!Cc.isGrounded && jump == 0)
        {
            //float adjustedSpeed = playerSpeed / 2; // Moves player with reduced speed.
            Cc.Move(new Vector3(0, -gravity * Time.deltaTime, 0));
        }
        
    }
}
