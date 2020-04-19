using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommentManager : MonoBehaviour
{
    public Text MyCommnet;
    int Kind;
    private void Start()
    {
        Kind = Random.Range(0, 6);

    }
    private void Update()
    {
        switch (Kind)
        {
            case 0:
                MyCommnet.text = "응애~";
                break;
            case 1:
                MyCommnet.text = "오늘 밥은 뭘까요`?";

                break;
            case 2:
                MyCommnet.text = "내 최고 점수가 몇점이지?";

                break;
            case 3:
                MyCommnet.text = "빨리 놀러 가고 싶어요!!";
                break;
            case 4:
                MyCommnet.text = "내 최고 점수는" + GameManager.GetInstance().HighestScore_1 + "점이야!!";

                break;
            case 5:
                MyCommnet.text = "너무 재밌다고 계속 하면 안돼~";

                break;
        }
    }
}
