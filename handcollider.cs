using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handcollider : MonoBehaviour
{

    public bool c = false;

    void OnCollisionStay(Collision collision)
    {
            c = true;
    }

    void OnCollisionExit(Collision collision)
    {
            c = false;      
    }

}
