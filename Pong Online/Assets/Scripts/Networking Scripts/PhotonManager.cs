using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 2 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            SpawnPlayer();
        }
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            SpawnPlayer2();
        }
    }

    public void SpawnPlayer()
    {
        GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate("Player1", new Vector3(8, 0, -1), Quaternion.identity);
        myPlayer.GetComponent<Movement>().enabled = true;
        //Instantiate(ball);
    }

    public void SpawnPlayer2()
    {
        GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate("Player1", new Vector3(-8, 0, -1), Quaternion.identity);
        myPlayer.GetComponent<Movement>().enabled = true;
        //Instantiate(ball);
        //BallMovement.score = GameObject.Find("Score").GetComponent<Text>();
        //StartCoroutine(StartGame());
    }

    public void SpawnBall()
    {
        ball = (GameObject)PhotonNetwork.Instantiate("Ball", new Vector3(0, 0, -1), Quaternion.identity);
    }

    public override void OnCreatedRoom()
    {
        SpawnBall();
    }
   
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(3);
        ball.GetComponent<BallMovement>().enabled = true;
    }
}
