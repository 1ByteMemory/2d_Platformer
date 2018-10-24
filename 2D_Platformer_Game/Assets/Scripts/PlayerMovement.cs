using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    CharacterController Cc;
    public float playerSpeed = 5.0f;
    public float playerMass = 0.5f;

    private BoxCollider isGrounded;

	// Use this for initialization
	void Start () {
        isGrounded = GetComponentInChildren<BoxCollider>();
        Cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        
        Cc.Move(new Vector3(h * playerSpeed * Time.deltaTime, 0, 0));
	}

    public void Ground(bool isGrounded)
    {
        if (isGrounded == false)
        {

        }
    }
}
