using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard_Move : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 1 && GameManager.instnce.Hp > 0 && GameManager.instnce.Condition > 0)
        {
            GameManager.GetInstance().Hp-= 5;
            GameManager.GetInstance().Condition -= 1;
            time = 0;
        }
        if(GameManager.instnce.Hp <= 0)
        {
            Debug.Log("GameOver");
        }
        speed = 5 + GameManager.instnce.Hp / 5;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigid.AddForce(new Vector2(-1 * speed,0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid.AddForce(new Vector2(1 * speed, 0));
        }
    }
}
