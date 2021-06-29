using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultsScene : MonoBehaviour
{
    public Text player1Score;
    public Text player2Score;

    public Text winner;

    public Text Player1Name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scores();
        Winner();
        PlayerOneName();
    }

    public void Menu()
    {
        BallMovement.Player1Score = 0;
        BallMovement.Player2Score = 0;
        SceneManager.LoadScene(0);
    }

    public void Scores()
    {
        player1Score.text = BallMovement.Player2Score.ToString();
        player2Score.text = BallMovement.Player1Score.ToString();
    }

    void Winner()
    {
        if(BallMovement.Player2Score > BallMovement.Player1Score)
        {
            if(MenuScript.ChosenName == null)
            {
                winner.text = "Player 1 Wins!!!";
            }
            winner.text = MenuScript.ChosenName + " Wins!!!";
        }
        else if (BallMovement.Player2Score < BallMovement.Player1Score)
        {
            winner.text = "Player 2 Wins!!!";
        }

    }

    void PlayerOneName()
    {
        Player1Name.text = MenuScript.ChosenName;
        if (MenuScript.ChosenName == null)
        {
            Player1Name.text = "Player 1";
        }
    }
}
