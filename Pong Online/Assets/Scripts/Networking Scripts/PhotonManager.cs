using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    GameObject ball;
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
        SpawnPlayer();
        SpawnPlayer2();
    }

    public void SpawnPlayer()
    {
        GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate("Player1", new Vector3(8, 0, -1), Quaternion.identity);
        myPlayer.GetComponent<Movement>().enabled = true;
    }

    public void SpawnPlayer2()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate("Player2", new Vector3(-8, 0, -1), Quaternion.identity);
            myPlayer.GetComponent<Movement>().enabled = true;
            StartCoroutine(StartGame());
        }
    }

    public override void OnCreatedRoom()
    {
        ball = (GameObject)PhotonNetwork.Instantiate("Ball", new Vector3(0, 0, -1), Quaternion.identity);

    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(3);
        ball.GetComponent<BallMovement>().enabled = true;
    }
}
