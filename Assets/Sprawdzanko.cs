using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Sprawdzanko : MonoBehaviour
{
    public Text winner;
    public GameObject panel;
    public bool trudne;
    public void Sprawdz()
    {
        if ((Tablica.k2[0].text is "O" && Tablica.k2[1].text is "O" && Tablica.k2[2].text == "O") || (Tablica.k2[3].text == "O" && Tablica.k2[4].text == "O" && Tablica.k2[5].text == "O") || (Tablica.k2[6].text == "O" && Tablica.k2[7].text == "O" && Tablica.k2[8].text == "O") || (Tablica.k2[0].text == "O" && Tablica.k2[3].text == "O" && Tablica.k2[6].text == "O") || (Tablica.k2[7].text == "O" && Tablica.k2[1].text == "O" && Tablica.k2[4].text == "O") || (Tablica.k2[8].text == "O" && Tablica.k2[5].text == "O" && Tablica.k2[2].text == "O") || (Tablica.k2[6].text == "O" && Tablica.k2[4].text == "O" && Tablica.k2[2].text == "O") || (Tablica.k2[5].text == "O" && Tablica.k2[4].text == "O" && Tablica.k2[2].text == "O") || (Tablica.k2[0].text == "O" && Tablica.k2[4].text == "O" && Tablica.k2[8].text == "O") && winner.text == null)
        {
            panel.SetActive(true);
            winner.text = "Wygrał O";
        }
        else if ((Tablica.k2[0].text == "X" && Tablica.k2[1].text == "X" && Tablica.k2[2].text == "X") || (Tablica.k2[3].text == "X" && Tablica.k2[4].text == "X" && Tablica.k2[5].text == "X") || (Tablica.k2[6].text == "X" && Tablica.k2[7].text == "X" && Tablica.k2[8].text == "X") || (Tablica.k2[0].text == "X" && Tablica.k2[3].text == "X" && Tablica.k2[6].text == "X") || (Tablica.k2[7].text == "X" && Tablica.k2[1].text == "X" && Tablica.k2[4].text == "X") || (Tablica.k2[8].text == "X" && Tablica.k2[5].text == "X" && Tablica.k2[2].text == "X") || (Tablica.k2[6].text == "X" && Tablica.k2[4].text == "X" && Tablica.k2[2].text == "X") || (Tablica.k2[5].text == "X" && Tablica.k2[4].text == "O" && Tablica.k2[2].text == "X") || (Tablica.k2[0].text == "X" && Tablica.k2[4].text == "X" && Tablica.k2[8].text == "X") && winner.text == null)
        {
            panel.SetActive(true);
            winner.text = "Wygrał X";
        }
        else if (Tablica.stop == 5 && (winner.text != "O" || winner.text != "X"))
        {
            panel.SetActive(true);
            winner.text = "Remis";
        }
        if(Tablica.k2[0].text is "X" && Tablica.k2[4].text is "X" && Tablica.k2[8].text == "X")
        {
            panel.SetActive(true);
            winner.text = "Wygrał X";
        }
        if (Tablica.k2[0].text is "O" && Tablica.k2[4].text is "O" && Tablica.k2[8].text == "O")
        {
            panel.SetActive(true);
            winner.text = "Wygrał O";
        }
    }
    void Start()
    {
        panel.SetActive(false);
    }
}
