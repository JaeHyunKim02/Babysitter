using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject RankingWindow;

    private void Start()
    {
        RankingWindow.SetActive(false);
    }

    public void WindowOn()
    {
        RankingWindow.SetActive(true);
    }
    public void WinodwOff()
    {
        RankingWindow.SetActive(false);
    }
}
