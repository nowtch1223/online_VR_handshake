using UnityEngine;
using Photon.Pun;
/// <summary>
/// 同期させたいアバターのルートにアタッチ
/// </summary>
public class AttachTarget : MonoBehaviourPunCallbacks
{
    bool once = true;

    [SerializeField]
    GameObject avater_Face, avater_RightHand, avater_LeftHand, avater_RightFoot, avater_LeftFoot;

    Transform cameraTransform;
    Transform rightHandTransform;
    Transform leftHandTransform;
    Transform rightFootTransform;
    Transform leftFootTransform;

    void Update()
    {
        if (photonView.IsMine && once) 
        {
            cameraTransform = GameObject.Find("HeadTarget1").GetComponent<Transform>();
            rightHandTransform = GameObject.Find("RightHandTarget1").GetComponent<Transform>();
            leftHandTransform = GameObject.Find("LeftHandTarget1").GetComponent<Transform>();
            rightFootTransform = GameObject.Find("RightFootTarget1").GetComponent<Transform>();
            leftFootTransform = GameObject.Find("LeftFootTarget1").GetComponent<Transform>();


            //親子関係を設定し、ローカルの座標系の原点に移動
            avater_Face.transform.parent = cameraTransform;
            avater_RightHand.transform.parent = rightHandTransform;
            avater_LeftHand.transform.parent = leftHandTransform;
            avater_RightFoot.transform.parent = rightFootTransform;
            avater_LeftFoot.transform.parent = leftFootTransform;

            avater_Face.transform.localPosition = Vector3.zero;
            avater_Face.transform.localRotation = Quaternion.identity;

            avater_RightHand.transform.localPosition = Vector3.zero;
            avater_RightHand.transform.localRotation = Quaternion.identity;

            avater_LeftHand.transform.localPosition = Vector3.zero;
            avater_LeftHand.transform.localRotation = Quaternion.identity;

            avater_RightFoot.transform.localPosition = Vector3.zero;
            avater_RightFoot.transform.localRotation = Quaternion.identity;

            avater_LeftFoot.transform.localPosition = Vector3.zero;
            avater_LeftFoot.transform.localRotation = Quaternion.identity;

            once = false;
        }

        if (!photonView.IsMine && once) 
        {
            cameraTransform = GameObject.Find("HeadTarget2").GetComponent<Transform>();
            rightHandTransform = GameObject.Find("RightHandTarget2").GetComponent<Transform>();
            leftHandTransform = GameObject.Find("LeftHandTarget2").GetComponent<Transform>();
            rightFootTransform = GameObject.Find("RightFootTarget2").GetComponent<Transform>();
            leftFootTransform = GameObject.Find("LeftFootTarget2").GetComponent<Transform>();


            //親子関係を設定し、ローカルの座標系の原点に移動
            avater_Face.transform.parent = cameraTransform;
            avater_RightHand.transform.parent = rightHandTransform;
            avater_LeftHand.transform.parent = leftHandTransform;
            avater_RightFoot.transform.parent = rightFootTransform;
            avater_LeftFoot.transform.parent = leftFootTransform;

            avater_Face.transform.localPosition = Vector3.zero;
            avater_Face.transform.localRotation = Quaternion.identity;

            avater_RightHand.transform.localPosition = Vector3.zero;
            avater_RightHand.transform.localRotation = Quaternion.identity;

            avater_LeftHand.transform.localPosition = Vector3.zero;
            avater_LeftHand.transform.localRotation = Quaternion.identity;

            avater_RightFoot.transform.localPosition = Vector3.zero;
            avater_RightFoot.transform.localRotation = Quaternion.identity;

            avater_LeftFoot.transform.localPosition = Vector3.zero;
            avater_LeftFoot.transform.localRotation = Quaternion.identity;
        }
            
        
    }
}