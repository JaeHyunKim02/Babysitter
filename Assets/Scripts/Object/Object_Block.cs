using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Block : MonoBehaviour
{
    public GameObject Wall;
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
            if (collision.gameObject.transform.position.x >= 0)
            {
                Instantiate(Wall, new Vector3(2.3f, -1, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(Wall, new Vector3(-2.3f, -1, 0), Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

//Instantiate(Bullet, transform.position, Quaternion.identity);