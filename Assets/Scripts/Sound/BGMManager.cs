using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioSource audio;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("BGMProgress"))
            PlayerPrefs.SetFloat("BGMProgress", 1f);
        audio.volume = PlayerPrefs.GetFloat("BGMProgress", default);
    }
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        audio.volume = PlayerPrefs.GetFloat("BGMProgress", default);
    }
}
