using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class NetworkController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // Connects to Phonton Master   
    }

    // Update is called once per frame
    public override void OnConnectedToMaster(){
        Debug.Log("We are now connected to the server!");
    }
}
