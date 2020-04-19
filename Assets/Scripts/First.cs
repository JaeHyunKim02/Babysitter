using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class First : MonoBehaviour
{
    public Sprite S1;
    public Sprite S2;
    public Sprite S3;
    public Sprite S4;
    public Sprite S5;
    public Sprite S6;
    public Sprite S7;
    public Sprite S8;
    public Sprite S9;

    private void Awake()
    {
        if (GameManager.GetInstance().MyScore == 0)
        {
            Starttutorial();
        }

    }

    void Starttutorial()
    {

    }
}
