using UnityEngine;

public class ExpandRetract : MonoBehaviour {
    
	void Update () {
        // Scales up and down.
        transform.localScale = new Vector3(transform.localScale.x, Mathf.PingPong(Time.time, 1));
	}
}
