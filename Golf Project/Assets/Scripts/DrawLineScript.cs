using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineScript : MonoBehaviour
{
    private LineRenderer lineDrawn;
    private Vector3 mousePos;
    public Rigidbody golfBall;
    private Plane plane = new Plane(Vector3.up, Vector3.zero);

    private void Start()
    {
        lineDrawn = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        DrawLineFromBallToMouse();

        ResetLinePossition();
    }

    private void DrawLineFromBallToMouse()
    {
        if (Input.GetMouseButton(0) && golfBall.IsSleeping())
        {
            Vector3 screenPoint = Input.mousePosition;
            screenPoint.z = 10;
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);

            lineDrawn.SetPosition(0, golfBall.transform.position);
            lineDrawn.SetPosition(1, worldPoint);
        }
    }

    private void ResetLinePossition()
    {
        if (Input.GetMouseButtonUp(0))
        {
            lineDrawn.SetPosition(0, Vector3.zero);
            lineDrawn.SetPosition(1, Vector3.zero);
        }
    }
}
