using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public Image mask;
    public Rigidbody golfBall;
    ApplyForce applyForceScript;
    // Start is called before the first frame update
    void Start()
    {
        GameObject applyForce = GameObject.Find(golfBall.name);
        applyForceScript = applyForce.GetComponent<ApplyForce>();
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float fillAmount = applyForceScript.clickForce / applyForceScript.maxClickForce;
        mask.fillAmount = fillAmount;
    }
}
