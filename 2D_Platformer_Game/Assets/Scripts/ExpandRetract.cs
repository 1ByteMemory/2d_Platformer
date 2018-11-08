using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandRetract : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.localScale = new Vector3(transform.localScale.x, Mathf.PingPong(Time.time, 1));
	}
}
