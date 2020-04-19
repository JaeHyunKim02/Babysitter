using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RankingManager : MonoBehaviour
{
    public Text HScore1;
    public Text HScore2;
    public Text HScore3;

    public void Update()
    {

        HScore1.text = "" + GameManager.GetInstance().HighestScore_1;
        HScore2.text = "" + GameManager.GetInstance().HighestScore_2;
        HScore3.text = "" + GameManager.GetInstance().HighestScore_3;



    }
}
