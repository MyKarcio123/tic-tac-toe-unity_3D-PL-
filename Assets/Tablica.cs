using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tablica : MonoBehaviour
{
    public Button[] test;
    public Text[] test12;
    public static Button[] k1;
    public static Text[] k2;
    public static int stop = 0;
    void Start()
    {
        k1 = new Button[9];
        k2 = new Text[9];
        for (int i =0;i!=9;i++)
        {
            k1[i] = test[i];
            k2[i] = test12[i];
        }
    }
}
