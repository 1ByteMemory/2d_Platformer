using UnityEngine;

public class Key : MonoBehaviour {

    public GameObject door;

    private bool called = false;

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
        UnlockDoor(door);
    }

    public void UnlockDoor (GameObject door)
    {
        if (!called)
        {
            Destroy(door);
            called = true;
        }
    }
}
