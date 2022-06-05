using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceSpeedArea : MonoBehaviour
{
    public Rigidbody golfBall;

    private bool isForceHalved = false;

    private void OnTriggerExit(Collider other)
    {
        isForceHalved = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if(!golfBall.IsSleeping() && !isForceHalved)
        {
            golfBall.velocity /= 2;
            isForceHalved = true;
        }

        if(golfBall.IsSleeping() && isForceHalved)
        {
            isForceHalved = false;
        }
    }
}
