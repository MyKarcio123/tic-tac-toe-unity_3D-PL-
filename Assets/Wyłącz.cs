using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Wyłącz : MonoBehaviour
{
    public string nastepna;
    public void wyjdz()
    {
        Application.Quit();
    }
    public void dalej()
    {
        SceneManager.LoadScene(nastepna, LoadSceneMode.Additive);
    }
}
