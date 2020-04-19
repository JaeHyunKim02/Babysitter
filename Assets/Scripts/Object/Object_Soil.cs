using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Soil: MonoBehaviour
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
            collision.GetComponent<Player>().PlayerStun(true);
            Destroy(gameObject);   //실험할때는 주석을 켜주시고 본 게임에선 주석을 없애주세요
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
