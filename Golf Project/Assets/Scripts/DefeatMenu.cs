using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatMenu : MonoBehaviour
{
    public bool isRestart;
    public bool isQuit;

    private void OnMouseUp()
    {
        if(isRestart)
        {
            SceneManager.LoadSceneAsync("Game");
        }

        if(isQuit)
        {
            Application.Quit();
        }
    }
}
