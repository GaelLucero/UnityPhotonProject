using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviourPunCallbacks
{
    public GameObject Speaker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine){
            //This is the local user
            float x = Input.GetAxis("Horizontal") * 10f * Time.deltaTime;
            float y = Input.GetAxis("Vertical") * 10f * Time.deltaTime;
            transform.Translate(x, 0, y);
            Speaker.transform.Translate(x,0,y);

        }
    }
}
