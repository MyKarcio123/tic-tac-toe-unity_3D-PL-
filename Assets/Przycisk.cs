using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Przycisk : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    public string playerSide;
    public Sprawdzanko sprawdzanko;
    public Text winner;
    public void SetSpace()
    {
        if (winner.text == "")
        {
            Tablica.stop++;
            this.buttonText.text = "X";
            this.button.interactable = false;
            sprawdzanko.Sprawdz();
            if (sprawdzanko.trudne == false)
            {
                if (Tablica.stop != 5)
                {
                    bool wyjscie = false;
                    int siema;
                    do
                    {
                        Random rnd = new Random();
                        siema = Random.Range(0, 9);
                        if (Tablica.k1[siema].interactable == true)
                        {
                            wyjscie = true;
                        }
                    } while (wyjscie == false);

                    Tablica.k1[siema].interactable = false;
                    Tablica.k2[siema].text = "O";
                    sprawdzanko.Sprawdz();
                }
            }
            else
            {
                if (Tablica.stop != 5)
                {
                    bool wyjscie = false;
                    int siema;
                    if (Tablica.k2[4].text != "X")
                    {
                        Tablica.k1[4].interactable = false;
                        Tablica.k2[4].text = "O";
                    }
                    else
                    {
                        do
                        {
                            Random rnd = new Random();
                            siema = Random.Range(0, 9);
                            if (Tablica.k1[siema].interactable == true)
                            {
                                wyjscie = true;
                            }
                        } while (wyjscie == false);

                        Tablica.k1[siema].interactable = false;
                        Tablica.k2[siema].text = "O";
                        sprawdzanko.Sprawdz();
                    }
                }
            }
        }
      
    }
}
