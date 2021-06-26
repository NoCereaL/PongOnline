using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManageer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Winner();
    }

    void Winner()
    {
        if(BallMovement.Player1Score == 7 || BallMovement.Player2Score == 7)
        {
            if(BallMovement.Player1Score > BallMovement.Player2Score)
            {
                Debug.Log("Player 2 Wins!!!");
                SceneManager.LoadScene(3);
            }
            if (BallMovement.Player2Score > BallMovement.Player1Score)
            {
                Debug.Log("Player 1 Wins!!!");
                SceneManager.LoadScene(3);
            }
        }
    }
}
