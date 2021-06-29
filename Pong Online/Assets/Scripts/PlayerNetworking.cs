using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetworking : MonoBehaviour, IPunObservable
{
    public GameObject player;
    public Movement Player;
    public MonoBehaviour[] scriptsToIgnore;
    private PhotonView photonView;
    public Vector3 realPos;
    // Start is called before the first frame update
    void Awake()
    {
        photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            //transform.position = Vector3.Lerp(transform.position, realPos, -1f);
            foreach(var script in scriptsToIgnore)
            {
                script.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
            return;

        var LagDistance = realPos - transform.position;

        //High distance => sync is to much off => send to position
        if(LagDistance.magnitude > 5f)
        {
            transform.position = realPos;
            LagDistance = Vector3.zero;
        }

        if(LagDistance.magnitude < 0.11f)
        {
            Player.GetComponent<Transform>().Equals(Vector3.zero);
        }
        else {
            Player.GetComponent<Transform>().Equals(LagDistance.normalized);
        }
        Debug.Log(realPos);
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(transform.position);
        }
        else
        {
            //transform.position = (Vector3)stream.ReceiveNext();
            realPos = (Vector3)stream.ReceiveNext();
        }
    }
}
