using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    public float minY;
    public float maxY;
    public float minX;
    public float maxX;

    // Start is called before the first frame update
    void Start()
    {
        Vector3  RandomPosition = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minY, maxY));
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, RandomPosition, Quaternion.identity);

        Color randomColor = getRandomColor();
        Debug.Log("That Random COlor: " + randomColor);
        player.GetComponent<Renderer>().material.color = randomColor;
    }


    private Color getRandomColor(){
        return new Color(
            r: UnityEngine.Random.Range(0f, 1f),
            g: UnityEngine.Random.Range(0f, 1f),
            b: UnityEngine.Random.Range(0f, 1f));
    }
}
