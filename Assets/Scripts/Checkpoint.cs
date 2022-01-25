using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print(gameObject.name + " was triggered by " + other.gameObject.name);
    }
}