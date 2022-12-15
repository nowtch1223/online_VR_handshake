using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveManager : MonoBehaviour
{
    public GameObject head;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject leftFoot;
    public GameObject rightFoot;

    public static ViveManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }

}
