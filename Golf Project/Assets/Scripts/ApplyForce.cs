using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    Rigidbody golfBall;
    private bool isForceApplied = false;
    private bool isMaxForceReached = false;

    public float clickForce = 0f;
    private const float forceToApply = 10f;
    private float minClickForce = 0f;
    public float maxClickForce = 3000f;
    private Plane plane = new Plane(Vector3.up, Vector3.zero);

    private void Start()
    {
        golfBall = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetForceApplied();

        IncrementHitCount();

        ApplyForceToBallTowardsMouse();
    }

    private void ApplyForceToBallTowardsMouse()
    {
        if (Input.GetMouseButtonUp(0) && golfBall.IsSleeping())
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            float enter;
            if (plane.Raycast(ray, out enter))
            {
                var hitPoint = ray.GetPoint(enter);
                var mouseDir = hitPoint - golfBall.transform.position;
                mouseDir = mouseDir.normalized;



                if (isForceApplied)
                {
                    golfBall.AddForce(mouseDir * clickForce);
                    isForceApplied = false;
                    clickForce = 0;
                }
            }
        }
    }

    private void IncrementHitCount()
    {
        if (golfBall.IsSleeping() && Input.GetMouseButtonUp(0))
        {
            ShotCounter.ScoreAmount++;
            isForceApplied = true;
        }
    }

    private void GetForceApplied()
    {
        if (Input.GetMouseButton(0) && golfBall.IsSleeping())
        {
            if (!isMaxForceReached && clickForce >= minClickForce && clickForce <= maxClickForce)
            {
                clickForce += forceToApply;
                if (clickForce >= maxClickForce)
                {
                    isMaxForceReached = true;
                }
            }
            else if (isMaxForceReached)
            {
                clickForce -= forceToApply;
                if (clickForce <= minClickForce)
                {
                    isMaxForceReached = false;
                }
            }
        }
    }
}


