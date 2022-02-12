using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    bool isTriggered;

    void OnTriggerEnter(Collider other)
    {
        var name = other.gameObject.name;
        Debug.Log(gameObject.name + " was triggered by " + name);
        if (name.Equals("Player"))
        {
            ScoreKeeper.Total += 100;
            isTriggered = true;
        }
    }

    void Update()
    {
        if (isTriggered)
        {
            //change color
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            //gameObject.GetComponent<BoxCollider>().isTrigger = false;

            //make it so it can't be triggered again until reset
            //ability to reset the trigger after all checkpoints have been triggered
            isTriggered = false;
        }
    }
}