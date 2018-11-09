using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {

    // The script to animate the lever and activate the trap.

    public GameObject fallingObject;                                         // Reference for the affected object when lever is activated.

    Animator anim;                                                           // variable for the Animator component.
    bool played = false;                                                     // Boolean to stop multiple activations.

    private void Start()                                                     // On the start of the scene.
    {
        anim = GetComponent<Animator>();                                     // Gets the animator component.
    }

    private void OnTriggerEnter(Collider other)                              // When something enters the trigger.
    {
        if (other.tag == "Player")                                           // if that something is the player.
        {
            if (played == false)                                             // If the lever has not yet been activated: 
            {
                played = true;                                               // The lever has been activated.
                anim.SetBool("On", true);                                    // Allows the animation to be played.
            }
        }
    }
 
    public void Release ()                                                   // Release is called by an event trigger in the animation.
    {
        fallingObject.GetComponent<Rigidbody>().useGravity = true;           // Gravity for the targeted object is turned on.
    }
}
