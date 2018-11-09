using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackPlatform : MonoBehaviour {

    // Script to break the platform when a specific object collids with it.

    Rigidbody rb;                                                  // Rigidbody reference
    public GameObject breaker;                                     // Reference to the object that will break the platform.



    void Start()                                                   // On the start of the scene.
    {
        rb = GetComponent<Rigidbody>();                            // Gets the rigidbody component on the gameObject this script is on.
        rb.useGravity = false;                                     // The gravity of the object is turned of.
        rb.isKinematic = true;                                     // This stops anything from affecting it.
    }

    private void OnCollisionEnter(Collision collision)             // When something collides with this object:
    {
        if (collision.collider.gameObject == breaker)              // If that something is the target breaker
        {
            rb.useGravity = true;                                  // Gravity is turned on
            rb.isKinematic = false;                                // Other objects can move this object.
        }
    }
}
