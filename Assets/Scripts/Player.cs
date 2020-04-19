using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    Animator animator;
    SpriteRenderer renderer;
    public GameObject Siso;
    public float Speed = 0.2f;
    float WalkFoce = 30.0f;
    int key = 0;
    float MaxSpeed= 2.0f;
    float time;
    bool StunOn = false;
    bool isBibrate = false;

    public GameObject ResultWindow;

    bool IsWalk;
    bool IsDie;
    bool IsHit;

    bool one = true;
    public GameObject Mark;
    private void Start()
    {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        renderer = gameObject.GetComponentInChildren<SpriteRenderer>();

        //GameManager.GetInstance().SPBar.fillAmount -= 0.7f;
        Init();
    }
    void FixedUpdate()
    {
        //if(GameManager.GetInstance().SPBar.fillAmount<= 0.5)
        //{

        //}

        if (GameManager.GetInstance().SPBar.fillAmount <= 0.3f)
        {
            
            //여기다가 스타트 쿠로틴
            Debug.Log("스타트 코루틴");
            if(one)
            StartCoroutine(MarkEF());
        }

        if (!StunOn)
        {

            if (Input.acceleration.x > this.Speed || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (GameManager.GetInstance().SPBar.fillAmount <= 0.3f)
                {
                    key = -1;
                    renderer.flipX = true;
                    IsWalk = true;
                }
                else
                {
                    key = 1;
                    renderer.flipX = false;
                    IsWalk = true;
                }
            }
            if (Input.acceleration.x < -this.Speed || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (GameManager.GetInstance().SPBar.fillAmount <= 0.3f)
                {
                    key = 1;
                    renderer.flipX = false;
                    IsWalk = true;
                }
                else
                {
                    key = -1;
                    renderer.flipX = true;
                    IsWalk = true;
                }
            }
        }

        time += Time.deltaTime;
        if (time >= 0.8f)
        {
            StunOn = false;
            WalkFoce = 30f;
        }
        if (IsDie)
        {
            animator.SetBool("IsDie", true);
            Debug.Log("게임 종료");
        }
        if (IsWalk)
            animator.SetBool("IsWalk", true);
        else
            animator.SetBool("IsWalk", false);


        if (GameManager.GetInstance().HitPlayer)
        {
            animator.SetBool("IsHit", true);
            GameManager.GetInstance().HitPlayer = false;

            //만약 체력이 없으면
        }
        else
        {
            animator.SetBool("IsHit", false);

        }

        float HPSpeed = GameManager.GetInstance().HPBar.fillAmount+0.3f;

        float speedx = Mathf.Abs(this.rigidbody2D.velocity.x);

        if (speedx < this.MaxSpeed)
        {
            this.rigidbody2D.AddForce(transform.right * key * this.WalkFoce*HPSpeed);
        }

        if (gameObject.transform.position.x >= 3f || gameObject.transform.position.x <= -3f||GameManager.GetInstance().HPBar.fillAmount==0.0f)
        {
            //죽음
            //결과창 띄우자

#if UNITY_ANDROID
            isBibrate = true;
            if (isBibrate)
            Handheld.Vibrate();
            isBibrate = false;
#endif
            ResultWindow.SetActive(true);
            GameManager.GetInstance().isDie = true;
            GameManager.GetInstance().NewScore(GameManager.GetInstance().MyScore);
        }

    }
    private void Init()
    {
        GameManager.GetInstance().isDie = false;
        ResultWindow.SetActive(false);
        isBibrate = false;
    }

    public void PlayerStun(bool Stun)
    {
        StunOn = Stun;
        time = 0;
    }

    public void BlockRun()
    {
        key = key * -1;
        WalkFoce = 300;
        time = 0;
    }

    IEnumerator MarkEF()
    {
        //yield return new WaitForSeconds(0.2f);

        int count = 0;
        while (count < 8)
        {
            Mark.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            Mark.SetActive(false);
            yield return new WaitForSeconds(0.3f);
            count++;
        }
        one = false;
        //StartCoroutine("MakrEF");

    }
}