using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text MyScore;

    private void Update()
    {
        Time.timeScale = 0f;
        MyScore.text = ""+GameManager.GetInstance().MyScore;
    }
}
