using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackPlatform : MonoBehaviour {

    Rigidbody rb;
    public GameObject breaker;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == breaker)
        {
            rb.useGravity = true;
        }
    }
}
