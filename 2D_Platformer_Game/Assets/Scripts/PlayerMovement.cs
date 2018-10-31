using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    CharacterController Cc;
    public float playerSpeed = 5f;
    public float jumpPower = 5f;
    public float weigth = 5f;
    public float maxAirTime = 1f;

    float airTime = 0f;
    bool fall = true;

	// Use this for initialization
	void Start () {
        Cc = GetComponent<CharacterController>();
        //airTime = maxJumpHieght + 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        bool jumpButton = Input.GetButton("Jump");

        if (Cc.isGrounded)
        {
            Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, 0, 0));
            airTime = 0f;
            fall = false;
        }

        if (jumpButton && airTime <= maxAirTime && fall == false)
        {
            airTime += 1 * Time.deltaTime;
            Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, jumpPower * Time.deltaTime, 0));
            if (Input.GetButtonUp("Jump")) { fall = true; }
        }
        
        if (!Cc.isGrounded)
        {
            airTime += 1 * Time.deltaTime;
            Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, -weigth * Time.deltaTime, 0));
        }
    }
}
