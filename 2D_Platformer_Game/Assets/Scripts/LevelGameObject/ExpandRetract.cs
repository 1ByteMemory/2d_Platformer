using UnityEngine;

public class ExpandRetract : MonoBehaviour {
    
    // Script for the scecond level with the spikes that rise out of the ground
    // and sink back in.


    // Happens every update.
	void Update () {
        // Scales the object up and down.
        transform.localScale = new Vector3(transform.localScale.x, Mathf.PingPong(Time.time, 1));
	}
}
