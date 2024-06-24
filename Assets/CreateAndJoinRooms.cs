using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;
using Photon.Realtime;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField nameinput;
    public TMP_InputField idInput;
    public PhotonView playerPrefab;
    // Start is called before the first frame update     RoomOptions
    public void JoinOrCreateRoom(){
        PhotonNetwork.JoinOrCreateRoom(idInput.text, new RoomOptions() {MaxPlayers = 4}, TypedLobby.Default, null);
    }
/*
    public override void OnCreatedRoom(){
        PhotonNetwork.LoadLevel("GameScene");
        Debug.Log("+++++ Created a Room ++++++++++");
    }

    */

    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("GameScene");
        Debug.Log("====== Joined a Room =========");
        Debug.Log("Player: " + nameinput.text + " joined room: " + idInput.text);

        // Creating a player at the 0,0,0 coordinates
        //PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
    }

/*
    //Not sure what to do when it fails so leaving it blank
    public void OnJoinRoomFailed(){

    }
    */

    /*
    // this meathod is used to return to a room
    public void OpRejoinRoom(){

    }
    */
}
