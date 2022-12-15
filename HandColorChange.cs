using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColorChange: MonoBehaviour
{

    public float limit; //色が変わりきる時間
    float countT = 0;　　//経過時間
    private Material BaseMaterial;
    private Color ChangeColor;
    private Color BufColor;

    private float R = 0;
    private float G = 0;
    private float B = 0;


    public GameObject hand;
    private bool col;//衝突判定

    public int ColorNumber=0;//変わる色の切り替え
    public int ColorNumberCount=0;

    // Start is called before the first frame update
    void Start()
    {
        BaseMaterial = this.GetComponent<Renderer>().material;//手のマテリアル
        ChangeColor = BaseMaterial.color; //変色用変数
        BufColor = BaseMaterial.color; //原色を保持する変数

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

            if (ColorNumberCount == 8)
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

                case 1://赤

                    //させたい色のRGB値
                    R = 255;
                    G = 0;
                    B = 0;

                    ChangeColor.r += ((R - BufColor.r * 255) * deltaT / (limit * 255));  
                    ChangeColor.g += ((G - BufColor.g * 255) * deltaT / (limit * 255));
                    ChangeColor.b += ((B - BufColor.b * 255) * deltaT / (limit * 255));
                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);

                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Debug.Log("time" + countT);
                        Debug.Log("RED" + ChangeColor.r);
                        Debug.Log("GREEN" + ChangeColor.g);
                        Debug.Log("BLUE" + ChangeColor.b);
                    }
                    break;

                case 2://オレンジ

                    //させたい色のRGB値
                    R = 255;
                    G = 127;
                    B = 0;

                    ChangeColor.r += ((R - BufColor.r * 255) * deltaT / (limit * 255));
                    ChangeColor.g += ((G - BufColor.g * 255) * deltaT / (limit * 255));
                    ChangeColor.b += ((B - BufColor.b * 255) * deltaT / (limit * 255));
                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);

                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Debug.Log("time" + countT);
                        Debug.Log("RED" + ChangeColor.r);
                        Debug.Log("GREEN" + ChangeColor.g);
                        Debug.Log("BLUE" + ChangeColor.b);
                    }
                    break;

                case 3://黄

                    //させたい色のRGB値
                    R = 255;
                    G = 255;
                    B = 0;

                    ChangeColor.r += ((R - BufColor.r * 255) * deltaT / (limit * 255));
                    ChangeColor.g += ((G - BufColor.g * 255) * deltaT / (limit * 255));
                    ChangeColor.b += ((B - BufColor.b * 255) * deltaT / (limit * 255));
                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);

                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Debug.Log("time" + countT);
                        Debug.Log("RED" + ChangeColor.r);
                        Debug.Log("GREEN" + ChangeColor.g);
                        Debug.Log("BLUE" + ChangeColor.b);
                    }
                    break;

                case 4://赤とマゼンタの　中間

                    //させたい色のRGB値
                    R = 255;
                    G = 0;
                    B = 127;

                    ChangeColor.r += ((R - BufColor.r * 255) * deltaT / (limit * 255));
                    ChangeColor.g += ((G - BufColor.g * 255) * deltaT / (limit * 255));
                    ChangeColor.b += ((B - BufColor.b * 255) * deltaT / (limit * 255));
                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);

                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Debug.Log("time" + countT);
                        Debug.Log("RED" + ChangeColor.r);
                        Debug.Log("GREEN" + ChangeColor.g);
                        Debug.Log("BLUE" + ChangeColor.b);
                    }
                    break;

                case 5://シアン

                    //させたい色のRGB値
                    R = 0;
                    G = 255;
                    B = 255;

                    ChangeColor.r += ((R - BufColor.r * 255) * deltaT / (limit * 255));
                    ChangeColor.g += ((G - BufColor.g * 255) * deltaT / (limit * 255));
                    ChangeColor.b += ((B - BufColor.b * 255) * deltaT / (limit * 255));
                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);


                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Debug.Log("time" + countT);
                        Debug.Log("RED" + ChangeColor.r);
                        Debug.Log("GREEN" + ChangeColor.g);
                        Debug.Log("BLUE" + ChangeColor.b);
                    }

                    break;

                case 6://青とシアンの間

                    //させたい色のRGB値
                    R = 0;
                    G = 127;
                    B = 255;

                    ChangeColor.r += ((R - BufColor.r * 255) * deltaT / (limit * 255));
                    ChangeColor.g += ((G - BufColor.g * 255) * deltaT / (limit * 255));
                    ChangeColor.b += ((B - BufColor.b * 255) * deltaT / (limit * 255));
                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);


                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Debug.Log("time" + countT);
                        Debug.Log("RED" + ChangeColor.r);
                        Debug.Log("GREEN" + ChangeColor.g);
                        Debug.Log("BLUE" + ChangeColor.b);
                    }

                    break;

                case 7://青

                    //させたい色のRGB値
                    R = 0;
                    G = 0;
                    B = 255;

                    ChangeColor.r += ((R - BufColor.r * 255) * deltaT / (limit * 255));
                    ChangeColor.g += ((G - BufColor.g * 255) * deltaT / (limit * 255));
                    ChangeColor.b += ((B - BufColor.b * 255) * deltaT / (limit * 255));
                    this.GetComponent<Renderer>().material.color = new Color(ChangeColor.r, ChangeColor.g, ChangeColor.b);


                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Debug.Log("time" + countT);
                        Debug.Log("RED" + ChangeColor.r);
                        Debug.Log("GREEN" + ChangeColor.g);
                        Debug.Log("BLUE" + ChangeColor.b);
                    }

                    break;
            }
        }else
        {
            ChangeColor = new Color(BufColor.r, BufColor.g, BufColor.b);
            this.GetComponent<Renderer>().material.color = new Color(BufColor.r, BufColor.g, BufColor.b);

            countT = 0;
        }
       
    }

}
