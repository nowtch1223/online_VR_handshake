using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject cameraRig;

    public GameObject AvatarPrefab;

    public GameObject headPrefab;
    public GameObject leftHandPrefab;
    public GameObject rightHandPrefab;
    public GameObject leftFootPrefab;
    public GameObject rightFootPrefab;

    void Start()
    {
        //マスターサーバーに接続
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("connect");
    }

    //マスターサーバーに接続成功した時に呼ばれる
    public override void OnConnectedToMaster()
    {
        //Roomという名前のルームを作成する、既存の場合は参加する
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
        Debug.Log("collect");
    }

    //ルームへの接続が成功したら呼ばれる
    public override void OnJoinedRoom()
    {
        Debug.Log("joined");
        //cameraRigにアバターをスポーンさせる
        PhotonNetwork.Instantiate(AvatarPrefab.name, cameraRig.transform.position, cameraRig.transform.rotation, 0);

        //HMDやViveTrackerの位置と回転に合わせて追従位置に対応するプレハブをスポーンさせる
        PhotonNetwork.Instantiate(headPrefab.name, ViveManager.Instance.head.transform.position, ViveManager.Instance.head.transform.rotation, 0);
        PhotonNetwork.Instantiate(leftHandPrefab.name, ViveManager.Instance.leftHand.transform.position, ViveManager.Instance.leftHand.transform.rotation, 0);
        PhotonNetwork.Instantiate(rightHandPrefab.name, ViveManager.Instance.rightHand.transform.position, ViveManager.Instance.rightHand.transform.rotation, 0);
        PhotonNetwork.Instantiate(leftFootPrefab.name, ViveManager.Instance.leftHand.transform.position, ViveManager.Instance.leftHand.transform.rotation, 0);
        PhotonNetwork.Instantiate(rightFootPrefab.name, ViveManager.Instance.rightHand.transform.position, ViveManager.Instance.rightHand.transform.rotation, 0);

    }
}
