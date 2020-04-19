using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FXButton : MonoBehaviour
{
    float FXProgress = 0f;
    public Sprite FXON;
    public Sprite FXOFF;

    // Start is called before the first frame update
    void Awake()
    {
        if (!PlayerPrefs.HasKey("FXProgress"))
            PlayerPrefs.SetFloat("FXProgress", 1f);

        //if (FXProgress == 1f)
        //    gameObject.GetComponent<Image>().sprite = FXON;
        //else if (FXProgress == 0f)
        //    gameObject.GetComponent<Image>().sprite = FXOFF;
    }

    // Update is called once per frame
    void Start()
    {
        FXProgress = PlayerPrefs.GetFloat("FXProgress", default);
    }
    public void FX_Button()
    {
        if (FXProgress == 0)
        {
            FXProgress = 1.0f;
            //gameObject.GetComponent<Image>().sprite = FXON;
        }
        else if (FXProgress == 1)
        {
            FXProgress = 0.0f;
            //gameObject.GetComponent<Image>().sprite = FXOFF;
        }
        PlayerPrefs.SetFloat("FXProgress", FXProgress);
    }
}
