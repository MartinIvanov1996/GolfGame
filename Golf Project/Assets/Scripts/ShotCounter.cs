using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotCounter : MonoBehaviour
{
    public static int ScoreAmount;
    private Text ScoreText;

    void Start()
    {
        ScoreText = GetComponent<Text>();
        ScoreAmount = 0;
    }


    void Update()
    {
        ScoreText.text = "Times Hit: " + ScoreAmount;
    }
}
