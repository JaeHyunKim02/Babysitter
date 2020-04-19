using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Doll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetInstance().isDie)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("wow");
            //GameManager.GetInstance().Condition += 50; //변수 이름은 일단 Hp라고 설정했는데 바꿔주세요
            //if (GameManager.GetInstance().Condition >= 101) GameManager.GetInstance().Condition = 100;
            GameManager.GetInstance().SPBar.fillAmount += 0.3f;

            Destroy(gameObject);   //실험할때는 주석을 켜주시고 본 게임에선 주석을 없애주세요
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
