using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CopyScript : MonoBehaviourPunCallbacks
{

    public int index = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine)
        {
            switch(index)
            {
                case 1://head
                    transform.position = ViveManager.Instance.head.transform.position;
                    transform.rotation = ViveManager.Instance.head.transform.rotation;
                    break;
                case 2://leftHand
                    transform.position = ViveManager.Instance.leftHand.transform.position;
                    transform.rotation = ViveManager.Instance.leftHand.transform.rotation;
                    break;
                case 3://rightHand
                    transform.position = ViveManager.Instance.rightHand.transform.position;
                    transform.rotation = ViveManager.Instance.rightHand.transform.rotation;
                    break;
                    
                case 4://leftFoot
                    transform.position = ViveManager.Instance.leftFoot.transform.position;
                    transform.rotation = ViveManager.Instance.leftFoot.transform.rotation;
                    break;
                case 5://rightFoot
                    transform.position = ViveManager.Instance.rightFoot.transform.position;
                    transform.rotation = ViveManager.Instance.rightFoot.transform.rotation;
                    break;
                    
            }
            
        }
    }
}
