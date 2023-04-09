using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehaviour : MonoBehaviour
{
    private float speed = 15.0f;
    private float rocketStrength = 15.0f;
    private float aliveTimer = 5.0f;
    private bool homing;

    private Transform target;

        // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(Transform newTarget)
    {
        target = homingTarget;
        homing = true;
        Destroy(gameObject, aliveTimer);
    }
}
