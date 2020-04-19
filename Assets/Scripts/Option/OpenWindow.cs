using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindow : MonoBehaviour
{
    public GameObject OptionWindow;
    private void Awake()
    {
        OptionWindow.SetActive(false);
    }
    public void OpenOptionWindow()
    {
        OptionWindow.SetActive(true);
    }
}
