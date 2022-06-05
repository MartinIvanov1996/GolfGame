using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public bool isMainMenu;
    public bool isRestart;
    public bool isQuit;

    private void OnMouseUp()
    {
        if(isMainMenu)
        {
            SceneManager.LoadSceneAsync("Main Menu");
        }

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
