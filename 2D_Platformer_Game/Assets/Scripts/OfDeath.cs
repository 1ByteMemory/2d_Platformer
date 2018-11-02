using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfDeath : MonoBehaviour {

    public int damage = 1;

    private Lives script;

    private void Start()
    {
        script = FindObjectOfType<Lives>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            script.PlayerLives(damage);
        }
    }
}
