using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform golfBall;

    public float speed = 0.125f;

    public Vector3 offset;

    private void LateUpdate()
    {
        CameraFollowsBall();
    }

    private void CameraFollowsBall()
    {
        Vector3 desiredPosition = golfBall.position + offset;
        Vector3 smoothedPossition = Vector3.Lerp(transform.position, desiredPosition, speed);

        transform.position = smoothedPossition;

        transform.LookAt(golfBall);
    }
}
