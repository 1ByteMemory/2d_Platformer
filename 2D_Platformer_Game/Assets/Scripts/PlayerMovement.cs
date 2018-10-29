using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    CharacterController Cc;
    public float playerSpeed = 5.0f;
    public float jumpSpees = 5.0f;
    public float gravity = 20.0f;
    public float maxJumpHieght = 2.0f;

    private float airTime;

	// Use this for initialization
	void Start () {
        Cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");

        Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, y * jumpSpees * Time.deltaTime, 0));

        if (!Cc.isGrounded)
        {
            airTime += Time.deltaTime * 2;
        }

        if (!Cc.isGrounded && y == 0 && airTime >= maxJumpHieght)
        {
            Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, gravity * Time.deltaTime * -1, 0));
        }

        if (Cc.isGrounded)
        {
            airTime = 0.0f;
        }
    }
}
