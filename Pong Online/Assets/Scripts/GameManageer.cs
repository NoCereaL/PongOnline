using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;

public class GameManageer : MonoBehaviour
{
    public GameObject ball;
    public static Text winner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BallMovement.score = GameObject.Find("Score").GetComponent<Text>();
        ball = GameObject.Find("Ball(Clone)");
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2){
            ball.GetComponent<BallMovement>().enabled = true;
        }
        Winner();
    }

    void Winner()
    {
        if(BallMovement.Player1Score == 7 || BallMovement.Player2Score == 7)
        {
            if(BallMovement.Player1Score > BallMovement.Player2Score)
            {
                Debug.Log("Player 2 Wins!!!");
                winner.text = "Player 2 Wins!!!";
                SceneManager.LoadScene(3);
            }
            if (BallMovement.Player2Score > BallMovement.Player1Score)
            {
                Debug.Log("Player 1 Wins!!!");
                winner.text = "Player 1 Wins!!!";
                SceneManager.LoadScene(3);
            }
        }
    }
}
