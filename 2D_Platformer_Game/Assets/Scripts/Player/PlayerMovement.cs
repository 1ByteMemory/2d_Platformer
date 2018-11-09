using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Definitions
    CharacterController Cc;                                         // Reference for the character controller
    public float playerSpeed = 5f;                                  // Players movment speed
    public float gravity = -8f;                                     // How fast the player will fall
    public float jumpHieght = 3f;                                   // How high the player can jump
    public float jumpPower = 3;                                     // How fast the player jumps

    float airTime;                                                  // How long the player is in the air
    float jump;                                                     // Float for the jump input. Up here as it nneds to stay the same between updates
	
	void Start () {                                                 // At the start of the scene
        airTime = jumpPower;                                        // AirTime is set to be jumpPower so that the player imiediatly falls.
        Cc = GetComponent<CharacterController>();                   // Asigns the character controller component.
    }

    
    void Update()
    {
        // Everything is in functions to try and keep it neat. 
        // ( I was prepareing for the need of more functions)
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
        // AxisRaw becuase I want it to be -1, 0 or 1.
        float hInput = Input.GetAxisRaw("Horizontal");


        // Stops the player from jumping too high.
        if (airTime <= 0)
        {
            jump = 0;                                               // jump is set to 0 to stop the player from moving up unstopped.
        }
        if (airTime > 0)
        {
            jump = Input.GetAxisRaw("Jump");                        // jump is set to the raw axis of jump input.
        }

        // Reset airTime when player is grounded.
        if (Cc.isGrounded) { airTime = jumpPower; }


        // Moves the player.
        Cc.Move(new Vector3(hInput * playerSpeed * Time.deltaTime, jump * jumpHieght * Time.deltaTime, 0));
        


        // Falling
        if (!Cc.isGrounded && jump == 0)                            // if player is in air and not allowed to countineu move up.
        {
            Cc.Move(new Vector3(0, gravity * Time.deltaTime, 0));   // Player falls.
        }
        
    }
}
