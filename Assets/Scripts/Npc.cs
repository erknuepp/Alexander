using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    private const float impulse = 5.0f;
    readonly System.Random rnd = new System.Random();
    readonly double MIN_VALUE = -1.0;
    readonly double MAX_VALUE = 1.0;
    
    private Rigidbody _rigidBodyComponent;
    readonly int interval = 1;
    float nextTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= nextTime)
        {
            float x = (float)(rnd.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE) * impulse;
            float z = (float)(rnd.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE) * impulse;
            float y = _rigidBodyComponent.velocity.y;

            //do something here every interval seconds
            _rigidBodyComponent.AddForce(new Vector3(x, y, z), ForceMode.Impulse);

            nextTime += interval;
        }
    }
}
