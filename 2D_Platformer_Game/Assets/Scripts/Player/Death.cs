using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    // Using a seperate script for colliding with death traps seamed like a good idea
    // to keep it neat.

    // Activates when the player collides with a object
    private void OnTriggerEnter(Collider other)
    {
        // If the collided object has been tagged "death"
        if (other.tag == "death")
        {
            // Accesses the GameManager script and executes the RestartLevel function.
            FindObjectOfType<GameManager>().RestartLevel();
        }
    }
}
