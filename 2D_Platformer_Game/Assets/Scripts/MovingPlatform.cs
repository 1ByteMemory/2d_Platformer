using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.SetParent(gameObject.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.SetParent(null);
        }
    }
}
