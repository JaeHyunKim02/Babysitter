using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMButton : MonoBehaviour
{


    public Sprite BGMON;
    public Sprite BGMOFF;
    float BGMProgress = 0.0f;

    // Start is called before the first frame update
    void Awake()
    {
        BGMProgress = PlayerPrefs.GetFloat("BGMProgress", default);
        //if (BGMProgress == 1f)
        //    gameObject.GetComponent<Image>().sprite = BGMON;
        //else if (BGMProgress == 0f)
        //    gameObject.GetComponent<Image>().sprite = BGMOFF;
    }

    // Update is called once per frame
    public void BGM_Button()
    {
        if (BGMProgress == 1)
        {
            BGMProgress = 0;
            //gameObject.GetComponent<Image>().sprite = BGMOFF;
            Debug.Log("Off");
        }
        else if (BGMProgress == 0)
        {
            BGMProgress = 1;
           //gameObject.GetComponent<Image>().sprite = BGMON;
            Debug.Log("ON");
        }

        PlayerPrefs.SetFloat("BGMProgress", BGMProgress);
    }
}
