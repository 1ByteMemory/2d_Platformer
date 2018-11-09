using UnityEngine;

public class Key : MonoBehaviour {

    // The script for the lock and key puzzle.

    public GameObject door;                             // Reference to the door that opens.
    
    private void OnTriggerEnter(Collider collision)     // When something enters the trigger of this object.
    {
        Destroy(gameObject);                            // Destories this object
        Destroy(door);                                  // Destroies the door.
    }
}
