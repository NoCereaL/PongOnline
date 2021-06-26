using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{

    public float xSpeed = 5;
    public float ySpeed = 5;
    public Rigidbody2D rb;
    public CircleCollider2D collider2D;
    public Text score;
    public static int Player1Score = 0;
    public static int Player2Score = 0;
    public int hitCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xSpeed, ySpeed);
        score.text = Player1Score.ToString() + " | " + Player2Score.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Border")
        {
            ySpeed = -ySpeed;
            hitCount++;
        }

        if(collision.collider.tag == "Player")
        {
            xSpeed = -xSpeed;
            hitCount++;
        }

        if (collision.collider.tag == "PlayerTop")
        {
            ySpeed = -ySpeed;
            hitCount++;
        }

        if (collision.collider.tag == "PlayerBottom")
        {
            ySpeed = -ySpeed;
            hitCount++;
        }

        if (collision.collider.tag == "Player1Goal") {
            transform.position = new Vector3(0f, 0f, -1f);
            score.text = Player1Score++.ToString() +" | "+ Player2Score.ToString();
            hitCount++;
        }

        if (collision.collider.tag == "Player2Goal")
        {
            transform.position = new Vector3(0f, 0f, -1f);
            score.text = Player1Score.ToString() + " | " + Player2Score++.ToString();
            hitCount++;
        }
    }

}
