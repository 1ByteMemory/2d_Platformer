using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    CharacterController Cc;
    public float playerSpeed = 5f;
    public float jumpSpees = 5f;
    public float gravity = 20f;
    public float maxJumpHieght = 2f;

    private float airTime = 0f;
    float y;


	// Use this for initialization
	void Start () {
        Cc = GetComponent<CharacterController>();
        airTime = maxJumpHieght + 1f;
        y = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");


        if (!Cc.isGrounded)
        {
            airTime += 1 * Time.deltaTime;
            if (airTime >= maxJumpHieght)
            {
                y = 0f;
                Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, -gravity * Time.deltaTime, 0));
            }
        }

        if (Cc.isGrounded)
        {
            airTime = 0f;
            y = Input.GetAxis("Jump");
            Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, y * jumpSpees * Time.deltaTime, 0));
        }
    }
}
