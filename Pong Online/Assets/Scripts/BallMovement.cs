using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class BallMovement : MonoBehaviourPun
{

    public float xSpeed = 5;
    public static float ySpeed = 5;
    public Rigidbody2D rb;
    public CircleCollider2D collider2D;
    public static Text score;
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
        score = GameObject.Find("Score").GetComponent<Text>();

        rb.velocity = new Vector2(xSpeed, ySpeed);

        IncreaseSpeed();

        score.text = Player1Score.ToString() + " | " + Player2Score.ToString();
        //photonView.RPC("TransferOwner1", RpcTarget.AllBuffered);
        //photonView.RPC("TransferOwner2", RpcTarget.AllBuffered);
        //TransferOwner();
    }

    void IncreaseSpeed()
    {
        if (hitCount == 25)
        {
            if (xSpeed > 0) { xSpeed = 6; }
            else { xSpeed = -6; }

            if(ySpeed > 0) { ySpeed = 6; }
            else {   ySpeed = -6; }
        }

        if (hitCount == 50)
        {
            if (xSpeed > 0){ xSpeed = 7; }
            else{ xSpeed = -7;}

            if (ySpeed > 0) { ySpeed = 7; }
            else { ySpeed = -7; }
        }

        if (hitCount == 100)
        {
            if (xSpeed > 0) { xSpeed = 8; }
            else { xSpeed = -8;}

            if(ySpeed > 0) { ySpeed = 8; }
            else { ySpeed = -8; }
        }

        if (hitCount == 150)
        {
            if (xSpeed > 0) { xSpeed = 9;}
            else { xSpeed = -9; }

            if(ySpeed > 0) { ySpeed = 9; }
            else { ySpeed = -9; }
        }

        if(hitCount == 200)
        {
            if (xSpeed > 0) { xSpeed = 10; }
            else { xSpeed = -10; }

            if (ySpeed > 0) { ySpeed = 10; }
            else { ySpeed = -10; }
        }

        if(hitCount == 225)
        {
            if (xSpeed > 0) { xSpeed = 11; }
            else { xSpeed = -11; }

            if (ySpeed > 0) { ySpeed = 11; }
            else { ySpeed = -11; }
        }

        if(hitCount == 250)
        {
            if (xSpeed > 0) { xSpeed = 13; }
            else { xSpeed = -13; }

            if (ySpeed > 0) { ySpeed = 13; }
            else { ySpeed = -13; }
        }

        if(hitCount == 275)
        {
            if (xSpeed > 0) { xSpeed = 15; }
            else { xSpeed = -15; }

            if (ySpeed > 0) { ySpeed = 15; }
            else { ySpeed = -15; }
        }

        if(hitCount == 300)
        {
            if (xSpeed > 0) { xSpeed = 20; }
            else { xSpeed = -20; }

            if (ySpeed > 0) { ySpeed = 20; }
            else { ySpeed = -20; }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Border")
        {
            ySpeed = -ySpeed;
            hitCount++;
        }

        if (collision.collider.tag == "Player")
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
            score.text = Player1Score++.ToString() + " | " + Player2Score.ToString();
            hitCount++;
        }

        if (collision.collider.tag == "Player2Goal")
        {
            transform.position = new Vector3(0f, 0f, -1f);
            score.text = Player1Score.ToString() + " | " + Player2Score++.ToString();
            hitCount++;
        }

        if(transform.position.x <= -8.5f) {
            transform.position = new Vector3(0f, 0f, -1f);
            score.text = Player1Score.ToString() + " | " + Player2Score++.ToString();
            hitCount++;
        }

        if(transform.position.x >= 8.5f)
        {
            transform.position = new Vector3(0f, 0f, -1f);
            score.text = Player1Score++.ToString() + " | " + Player2Score.ToString();
            hitCount++;
        }
    }

    [PunRPC]
    void TransferOwner1()
    {
        float center = Screen.width - (Screen.width / 2);
        if (transform.position.x > 0)
        {
            Debug.Log("Player1");
            photonView.TransferOwnership(1);
        }
    }

    [PunRPC]
    void TransferOwner2()
    {
        float center = Screen.width - (Screen.width / 2);
        if (transform.position.x < 0)
        {
            Debug.Log("Player2");
            photonView.TransferOwnership(2);
        }
    }
}
