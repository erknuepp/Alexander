using UnityEngine;

public class Player : MonoBehaviour
{
    // Adjust the speed for the player cube.
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        transform.position =
            Vector3.MoveTowards(
                current: transform.position,
                target: new Vector3(pos.x, pos.y, pos.z - 10),
                maxDistanceDelta: speed * Time.deltaTime);
    }
}