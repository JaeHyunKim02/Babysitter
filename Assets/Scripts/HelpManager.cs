using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelpManager : MonoBehaviour
{
    public Image Help1;
    public Image Help2;
    public Image Help3;
    public Image Help4;
    public Image Help5;
    public Image Help6;
    public Image Help7;
    public Image Help8;
    public Image Help9;

    private int Turn = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            switch (Turn)
            {
                case 1:
                    Help1.gameObject.SetActive(false);
                    Help2.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 2:
                    Help2.gameObject.SetActive(false);
                    Help3.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 3:
                    Help3.gameObject.SetActive(false);
                    Help4.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 4:
                    Help4.gameObject.SetActive(false);
                    Help5.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 5:
                    Help5.gameObject.SetActive(false);
                    Help6.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 6:
                    Help6.gameObject.SetActive(false);
                    Help7.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 7:
                    Help7.gameObject.SetActive(false);
                    Help8.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 8:
                    Help8.gameObject.SetActive(false);
                    Help9.gameObject.SetActive(true);
                    Turn++;
                    break;
                case 9:
                    SceneManager.LoadScene("HomeScene");
                    break;
            }
        }
    }
}
