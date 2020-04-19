using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoIngame : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void GoInGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void GoHelpScene()
    {
        SceneManager.LoadScene("HelpScene");
    }

}
