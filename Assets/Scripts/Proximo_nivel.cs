using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Proximo_nivel : MonoBehaviour
{
    public string proximo_nivel;
    public string nombre_nivel;
    public void IraProximoNivel()
    {
        SceneManager.LoadScene(proximo_nivel, LoadSceneMode.Single);
    }

    public void IraCreditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }

    public void RepetirNivel()
    {
        SceneManager.LoadScene(nombre_nivel, LoadSceneMode.Single);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
