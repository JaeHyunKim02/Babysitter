using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour
{
    public AudioClip Touch;
    public AudioClip WindowOff;
    public AudioClip wowItisItem;


    public AudioSource audio_F;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("FXProgress"))
            PlayerPrefs.SetFloat("FXProgress", 1f);
    }
    void Start()
    {

    }

    void Update()
    {

        audio_F.volume = PlayerPrefs.GetFloat("FXProgress", default);
    }

    public void SoundManager_F(string audioName)//        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch"); 나오고 싶은 곳에 이렇게 사용
    {

        if (audioName == "Touch")
        {
            audio_F.PlayOneShot(Touch);
        }

        if (audioName == "WindowOff")
        {
            audio_F.PlayOneShot(WindowOff);
        }
        if(audioName == "wow")
        {
            audio_F.PlayOneShot(wowItisItem);
            
        }
    }
}
