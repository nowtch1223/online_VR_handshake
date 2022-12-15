using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Leap;
using Leap.Unity;

//ネットワークオブジェクトが自分の物でない時はオブジェクトを機能しなくする
public class notmine2 : MonoBehaviourPunCallbacks
{
    void Start()
    {
        var HMM = GetComponent<HandModelManager>();
        if (photonView.IsMine)
        {
            HMM.enabled = true;
        }
        else
        {
            HMM.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var HMM = GetComponent<HandModelManager>();
        if (photonView.IsMine)
        {
            HMM.enabled = true;
        }
        else
        {
            HMM.enabled = false;
        }
    }
}
