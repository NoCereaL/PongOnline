using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour
{
    public float speed = 10;
    public Vector3 position;
    public int getTouches = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        Move();
        TouchMove2();
        TouchMove();
    }

    void Move()
    {
        Vector3 veritcalMove = new Vector3(0f, Input.GetAxis("P2_Vertical"), 0f);
        transform.position += veritcalMove * Time.deltaTime * speed;
    }

    void TouchMove()
    {
        Touch touch = Input.GetTouch(1);
        position = Camera.main.ScreenToWorldPoint(touch.position);
        if (position.x <= 0)
        {
            transform.position = new Vector3(transform.position.x, position.y, transform.position.z);
        }
    }

    void TouchMove2()
    {
        Touch touch = Input.GetTouch(0);
        position = Camera.main.ScreenToWorldPoint(touch.position);
        if (position.x <= 0)
        {
            transform.position = new Vector3(transform.position.x, position.y, transform.position.z);
        }
    }
}
