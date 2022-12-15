using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_Changer : MonoBehaviour
{
    //public int Q = 0;//各質問の番号
    public int QC = 0;//質問カウント
    public GameObject[] question;


    //質問を切り替えるためのスクリプト
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            QC++;
            if (QC == question.Length+1)
                QC = 0;
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            QC--;
            if (QC == -1)
                QC = question.Length;
        }

        if (QC != 0)
        {
            for (int i = 0; i < question.Length; i++)
            {
                question[i].gameObject.SetActive(false);
            }
            question[QC - 1].gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < question.Length; i++)
            {
                question[i].gameObject.SetActive(false);
            }

        }
    }
}
