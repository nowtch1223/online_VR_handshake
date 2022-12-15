using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    private bool t = true;
    // Start is called before the first frame update
    //部屋Aと部屋Bを入れ替えるためのスクリプト

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (t)
            {
                this.transform.position = new Vector3(0, 0, -0.5f);
                t = false;
            }
            else
            {
                this.transform.position = new Vector3(-10, 0, -0.5f);
                t = true;
            }
        }
    }
}
