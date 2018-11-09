using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {

    // This script is on the colliders on the side of the box. 
    // I felt that this was the best way to do it.
    public float boxMoveSpeed = 1f;                                                             // How fast the box will move when the player collides with it.

    public GameObject parent;                                                                   // Reference to the box.
 
    private void OnTriggerStay(Collider other)                                                  // While something is colliding with it.
    {
        if (other.tag == "Player")                                                              // If that something is the player.
        {  
            if (gameObject.tag == "LCollider")                                                  // If this gameObject is the left trigger
            {
                parent.transform.position += new Vector3(boxMoveSpeed * Time.deltaTime, 0, 0);  // Move the box to the right.
            }
            else if (gameObject.tag == "RCollider")                                             // If this gameObject is the right trigger
            {
                parent.transform.position += new Vector3(-boxMoveSpeed * Time.deltaTime, 0);    // Movethe box to the left.
            }
        }
    }
}
