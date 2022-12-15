using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyokugen_color: MonoBehaviour
{

    public float limit; //色が変わりきる時間
    float countT = 0;　　//経過時間
    private Material BaseMaterial;
    private Color ChangeColor;
    private Color ReverseColor;
    private Color BufColor;


    //予備実験用　変化させたい色
    private float R = 1;
    private float G = 0;
    private float B = 0;


    


    public GameObject hand;
    private bool col;//衝突判定

    public int ColorNumber = 0;//変わる色の切り替え
    public int ColorNumberCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        BaseMaterial = this.GetComponent<Renderer>().material;//手のマテリアル
        ChangeColor = BaseMaterial.color; //変色用変数
        ReverseColor = BaseMaterial.color; //変色用変数
        BufColor = BaseMaterial.color; //原色を保持する変数

        ReverseColor.r = R ;
        ReverseColor.g = G ;
        ReverseColor.b = B ;

        Debug.Log(BaseMaterial.color.r);

    }

    // Update is called once per frame
    void Update()
    {
        col = hand.GetComponent<handcollider>().c;
        countT += Time.deltaTime;
        float deltaT = Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.C))
        {
            ColorNumberCount += 1;

            if (ColorNumberCount == 3)
            {
                ColorNumberCount = 0;
            }
            ColorNumber = ColorNumberCount;
        }

        if (col)//衝突したら
        {
            switch (ColorNumber)
            {
                case 0://変化なし
                    break;

                case 1:// 昇順

                    //させたい色のRGB値

                    ChangeColor.r += ((R - BufColor.r) * deltaT / (limit));
                    ChangeColor.g += ((G - BufColor.g) * deltaT / (limit));
                    ChangeColor.b += ((B - BufColor.b) * deltaT / (limit));

                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        Debug.Log("time = " + countT);
                        Debug.Log("RED = " + ChangeColor.r);
                        Debug.Log("GREEN = " + ChangeColor.g);
                        Debug.Log("BLUE = " + ChangeColor.b);
                    }
                    break;

                case 2://　降順

                    if (countT >= limit)
                        break;

                    ReverseColor.r += ((BufColor.r - R) * deltaT / (limit));
                    ReverseColor.g += ((BufColor.g - G) * deltaT / (limit));
                    ReverseColor.b += ((BufColor.b - B) * deltaT / (limit));


                    this.GetComponent<Renderer>().material.color = new Color(ReverseColor.r, ReverseColor.g, ReverseColor.b);

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        Debug.Log("time = " + countT);
                        Debug.Log("RED = " + ReverseColor.r);
                        Debug.Log("GREEN = " + ReverseColor.g);
                        Debug.Log("BLUE = " + ReverseColor.b);
                    }
                    break;
            }
        }
        else
        {
            ChangeColor = new Color(BufColor.r, BufColor.g, BufColor.b);
            this.GetComponent<Renderer>().material.color = new Color(BufColor.r, BufColor.g, BufColor.b);

            countT = 0;
        }

    }

}