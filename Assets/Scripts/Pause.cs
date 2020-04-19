using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject PauseUI;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        PauseUI.SetActive(false);

    }

    private void Update()
    {

    }

    public void PauseGame()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

 
}
