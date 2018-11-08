using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "death")
        {
            FindObjectOfType<GameManager>().RestartLevel();
        }
    }
}
