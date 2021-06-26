using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    public Vector3 mouseCoords;
    public Vector3 position;
    public int getTouches = 0; 
    //public static Touch touch = Input.GetTouch(Input.touchCount - 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        TouchMove();
        TouchMove2();
        
    }

    void Move()
    {
        Vector3 verticalMove = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += verticalMove * Time.deltaTime * speed;
    }

    void TouchMove()
    {
        Touch touch = Input.GetTouch(0);
        position = Camera.main.ScreenToWorldPoint(touch.position);
        if (position.x >= 0)
        {
            transform.position = new Vector3(transform.position.x, position.y, transform.position.z);
        }
        Debug.Log(Input.touchCount);
    }

    void TouchMove2()
    {
        Touch touch = Input.GetTouch(1);
        position = Camera.main.ScreenToWorldPoint(touch.position);
        if (position.x >= 0)
        {
            transform.position = new Vector3(transform.position.x, position.y, transform.position.z);
        }
        Debug.Log(Input.touchCount);
    }

    void MouseMove()
    {
        mouseCoords = Input.mousePosition;
        mouseCoords = Camera.main.ScreenToWorldPoint(mouseCoords);
        transform.position = new Vector3(transform.position.x, mouseCoords.y, transform.position.z);
    }
}
