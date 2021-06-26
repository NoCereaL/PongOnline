using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultsScene : MonoBehaviour
{
    public Text player1Score;
    public Text player2Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scores();
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
}
