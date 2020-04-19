using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private float cooldown = 1.5f;
    private int level = 1;
    public GameObject GO1; // 분유
    public GameObject GO2; // 기저귀
    public GameObject GO3; // 딸랑이
    public GameObject GO4; // 인형
    public GameObject GO5; // 찢어진 인형
    public GameObject GO6; // 똥
    public GameObject GO7; // 블럭
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ItemSpawn");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            level++;
        }
    }
    IEnumerator ItemSpawn()
    {
        yield return new WaitForSeconds(cooldown);
        //내용적기
        int rand = Random.Range(1, 100);
        switch (level)
        {
            case 1:
                if (rand >= 1 && rand <= 40) Instantiate(GO1, new Vector3(Random.Range(-2.5f, 2.5f),       5, 0), Quaternion.identity);
                else if (rand >= 41 && rand <= 60) Instantiate(GO2, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 61 && rand <= 70) Instantiate(GO4, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 71 && rand <= 85) Instantiate(GO5, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 86 && rand <= 95) Instantiate(GO6, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 96 && rand <= 100) Instantiate(GO7, new Vector3(Random.Range(-2.5f, 2.5f),5, 0), Quaternion.identity);
                break;
            case 2:
                if (rand >= 1 && rand <= 30) Instantiate(GO1, new Vector3(Random.Range(-2.5f, 2.5f),       5, 0), Quaternion.identity);
                else if (rand >= 31 && rand <= 50) Instantiate(GO2, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 51 && rand <= 85) Instantiate(GO5, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 86 && rand <= 95) Instantiate(GO6, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 96 && rand <= 100) Instantiate(GO7, new Vector3(Random.Range(-2.5f, 2.5f),5, 0), Quaternion.identity);
                break;
            case 3:
                if (rand >= 1 && rand <= 25) Instantiate(GO1, new Vector3(Random.Range(-2.5f, 2.5f),       5, 0), Quaternion.identity);
                else if (rand >= 26 && rand <= 40) Instantiate(GO2, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 41 && rand <= 50) Instantiate(GO3, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 51 && rand <= 60) Instantiate(GO4, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 61 && rand <= 87) Instantiate(GO5, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 88 && rand <= 97) Instantiate(GO6, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 98 && rand <= 100) Instantiate(GO7, new Vector3(Random.Range(-2.5f, 2.5f),5, 0), Quaternion.identity);
                break;
            case 4:
                if (rand >= 1 && rand <= 15) Instantiate(GO1, new Vector3(Random.Range(-2.5f, 2.5f), 2, 0), Quaternion.identity);
                else if (rand >= 16 && rand <= 35) Instantiate(GO2, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 36 && rand <= 50) Instantiate(GO3, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 51 && rand <= 65) Instantiate(GO4, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 66 && rand <= 82) Instantiate(GO5, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 83 && rand <= 97) Instantiate(GO6, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 98 && rand <= 100) Instantiate(GO7, new Vector3(Random.Range(-2.5f, 2.5f), 2, 0), Quaternion.identity);
                break;
            case 5:
                if (rand >= 1 && rand <= 10) Instantiate(GO1, new Vector3(Random.Range(-2.5f, 2.5f),       5, 0), Quaternion.identity);
                else if (rand >= 11 && rand <= 25) Instantiate(GO2, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 26 && rand <= 40) Instantiate(GO3, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 41 && rand <= 60) Instantiate(GO4, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 61 && rand <= 75) Instantiate(GO5, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 76 && rand <= 97) Instantiate(GO6, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);
                else if (rand >= 98 && rand <= 100) Instantiate(GO7, new Vector3(Random.Range(-2.5f, 2.5f),5, 0), Quaternion.identity);
                break;

        }
        StartCoroutine("ItemSpawn");
    }
}
//Instantiate(Wall, new Vector3(-2.5f, -3, 0), Quaternion.identity);