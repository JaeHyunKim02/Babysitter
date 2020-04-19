using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int MyScore = 0;
    public int HScore;

    public int Hp = 100;
    public int Condition = 100;
    public bool HitPlayer;

    public Image HPBar;
    public Image SPBar;

    public int HighestScore_1 = 0;
    public int HighestScore_2 = 0;
    public int HighestScore_3 = 0;

    public bool isDie = false;

    public static GameManager instnce = null;
    public static GameManager GetInstance()//싱글톤
    {
        if (instnce == null)
        {
            instnce = FindObjectOfType<GameManager>();
            if (instnce == null)
            {
                GameObject container = new GameObject("GameManager");
                container.AddComponent<GameManager>();

            }
        }
        return instnce;

    }
    private void Awake()
    {
        //if (instnce != null)
        //    Destroy(instnce);

        //instnce = this;

        HighestScore_1 = PlayerPrefs.GetInt("HighestScore_1");//최고 점수 불러오기
        HighestScore_2 = PlayerPrefs.GetInt("HighestScore_2");//최고 점수 불러오기
        HighestScore_3 = PlayerPrefs.GetInt("HighestScore_3");//최고 점수 불러오기

    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("HighestScore_1", HighestScore_1);//최고 점수 저장
        PlayerPrefs.SetInt("HighestScore_2", HighestScore_2);//최고 점수 저장
        PlayerPrefs.SetInt("HighestScore_3", HighestScore_3);//최고 점수 저장

    }
    //void EndGame()
    //{
    //    if (HPBar.fillAmount == 0.0f || SPBar.fillAmount == 0.0f)
    //    {

    //    }

    //}
    public void NewScore(int _MyScore)
    {
        int newscore = 0;

        if (_MyScore > HighestScore_1)
        {
            newscore = 1;
        }
        else if (_MyScore > HighestScore_2)
        {
            newscore = 2;
        }
        else if (_MyScore > HighestScore_3)
        {
            newscore = 3;
        }
        else newscore = 0;

        if (newscore == 0)
            return;
        else if (newscore == 3)
            HighestScore_3 = _MyScore;
        else if (newscore == 2)
            HighestScore_2 = _MyScore;
        else if (newscore == 1)
            HighestScore_1 = _MyScore;

        SaveScore();

    }


}
