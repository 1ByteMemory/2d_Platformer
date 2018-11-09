using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public GameObject player;                                             // A reference to the player.
                                                                          
    private void OnTriggerEnter(Collider other)                           // When the platform collides with an object
    {                                                                     
        if (other.tag == "Player")                                        // Checks the that object is the player.
        {                                                                 
            player.transform.SetParent(gameObject.transform);             // Sets the player to be a child of the platform so that the player moves with it.
        }                                                                 
    }                                                                     
                                                                          
    private void OnTriggerExit(Collider other)                            // When the player exits the trigger on the platform:
    {                             
        if (other.tag == "Player")
        {                         
            player.transform.SetParent(null);                             // The player is orphaned.
        }
    }
}
