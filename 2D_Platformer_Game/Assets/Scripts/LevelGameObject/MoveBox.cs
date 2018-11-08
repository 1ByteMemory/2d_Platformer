using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {

    public float boxMoveSpeed = 1f;

    public GameObject parent;
    

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {



            if (gameObject.tag == "LCollider")
            {
                parent.transform.position += new Vector3(boxMoveSpeed * Time.deltaTime, 0, 0);
            }
            else if (gameObject.tag == "RCollider")
            {
                parent.transform.position += new Vector3(-boxMoveSpeed * Time.deltaTime, 0);
            }
        }
    }
}
