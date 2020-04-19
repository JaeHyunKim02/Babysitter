using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siso : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float threshold = 0.2f;
    int key = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.acceleration.x > this.threshold||Input.GetKeyDown(KeyCode.A)) key = 1;
        //if (Input.acceleration.x < -this.threshold || Input.GetKeyDown(KeyCode.D)) key = -1;
        //float speedx = Mathf.Abs(this.rigidbody2D.velocity.x);


        if (Input.GetKeyDown(KeyCode.A)) { transform.rotation = Quaternion.Euler(0, 0, 30); }
        if (Input.GetKeyDown(KeyCode.D)) transform.rotation = Quaternion.Euler(0, 0, -30);
    }
}
