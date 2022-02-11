using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var name = other.gameObject.name;
        Debug.Log(gameObject.name + " was triggered by " + name);
        if (name.Equals("Player"))
        {
            ScoreKeeper.Total += 100;
        }
    }
}