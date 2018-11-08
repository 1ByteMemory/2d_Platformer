using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {

    public GameObject fallingObject;

    Animator anim;
    bool played = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (played == false)
            {
                played = true;
                anim.SetBool("On", true);
            }
        }
    }

    public void Release ()
    {
        fallingObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
