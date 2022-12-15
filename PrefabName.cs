using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PrefabName : MonoBehaviourPunCallbacks
{ 
    public int index = 0;

    // Start is called before the first frame update

    //自分と相手の名前を分けるためのスクリプト
    void Start()
    {
        if(photonView.IsMine)
        {
            switch (index)
            {
                case 0://avater                   
                    this.name = "Player1";
                    break;
                case 1://head    
                    this.name = "HeadTarget1";
                    break;
                case 2://LeftHand
                    this.name = "LeftHandTarget1";
                    break;
                case 3://RightHand            
                    this.name = "RightHandTarget1";
                    break;
                case 4://LeftFoot              
                    this.name = "LeftFootTarget1";
                    break;
                case 5://RightFoot
                    this.name = "RightFootTarget1";
                    break;
            }
        }
        else
        {
            switch (index)
            {
                case 0://avater                   
                    this.name = "Player2";
                    break;
                case 1://head    
                    this.name = "HeadTarget2";
                    break;
                case 2://LeftHand
                    this.name = "LeftHandTarget2";
                    break;
                case 3://RightHand            
                    this.name = "RightHandTarget2";
                    break;
                case 4://LeftFoot              
                    this.name = "LeftFootTarget2";
                    break;
                case 5://RightFoot
                    this.name = "RightFootTarget2";
                    break;
            }
        }
    }
}
