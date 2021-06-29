using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScores : MonoBehaviour
{
    public int getScore1 = BallMovement.Player1Score;
    public int getScore2 = BallMovement.Player2Score;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
        
    }
}
