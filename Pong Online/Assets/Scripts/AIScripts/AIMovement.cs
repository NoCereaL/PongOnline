using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{

    public GameObject ball;
    public Rigidbody2D AIRB;
    public static SpriteRenderer spriteRenderer;
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GameObject.Find("AI").GetComponent<SpriteRenderer>();
        //FollowBall();
        FollowBall2();
        IncereaseSpeed();
    }

    void IncereaseSpeed()
    {
        if(BallMovement.ySpeed == 6 || BallMovement.ySpeed == -6) {
            speed = 5f;
        }

        if(BallMovement.ySpeed == 7 || BallMovement.ySpeed == -7)
        {
            speed = 6f;
        }

        if(BallMovement.ySpeed == 9 || BallMovement.ySpeed == -9)
        {
            speed = 8f;
        }

        if (BallMovement.ySpeed == 11 || BallMovement.ySpeed == -11)
        {
            speed = 9f;
        }

        if (BallMovement.ySpeed == 13 || BallMovement.ySpeed == -13)
        {
            speed = 12f;
        }

        if (BallMovement.ySpeed == 15 || BallMovement.ySpeed == -15)
        {
            speed = 14f;
        }
    }

    void FollowBall()
    {
        Vector3 ballPosition = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);

        if (ball.transform.position.x <= 0)
        {
            AIRB.velocity = new Vector2(0f, BallMovement.ySpeed * 0.5f);
        }
        else
        {
            AIRB.velocity = new Vector2(0f, BallMovement.ySpeed * 0.1f);
        }

        //transform.position = ballPosition;
    }

    void FollowBall2()
    {
        if (ball.transform.position.x <= 0)
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                new Vector3(transform.position.x, ball.transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
        else if (ball.transform.position.x >= 0)
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                new Vector3(transform.position.x, ball.transform.position.y, transform.position.z), 1f * Time.deltaTime);
        }
    }

}
