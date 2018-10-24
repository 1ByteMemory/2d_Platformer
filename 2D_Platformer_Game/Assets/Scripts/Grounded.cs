using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        BroadcastMessage("Ground", true);
    }

    private void OnTriggerExit(Collider other)
    {
        BroadcastMessage("Ground", false);
    }
}
