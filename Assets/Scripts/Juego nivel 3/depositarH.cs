using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class depositarH : MonoBehaviour
{
    public Text BuscarSol;
    public Text depositarSol;
    public Text procesando;
    public Text completo;
    public Text generar;
    public Text Felicita;
    public Image informacion2;
    public GameObject canvas_ganador_hikari;

    public GameObject canvas_yami_perdedor;

    public Canvas canvas_yamis_y_hikari;
    void Start()
    {
        BuscarSol.enabled = false;
        depositarSol.enabled = false;
        procesando.enabled = false;
        completo.enabled = false;
        generar.enabled = false;
        Felicita.enabled = false;
        informacion2.enabled = false;
        canvas_ganador_hikari.SetActive(false);
        canvas_yami_perdedor.SetActive(false);

    }
    void OnTriggerStay(Collider other)
    {

        if (other.name == "Hikari_2.0")
        {
            if (other.GetComponent<inventarioobjetos3H>().ibSol == true)
            {
                informacion2.enabled = true;
                depositarSol.enabled = true;
                if (Input.GetKey(KeyCode.T))
                {
                    other.GetComponent<inventarioobjetos3H>().ibSol = false;
                    depositarSol.enabled = false;
                    procesando.enabled = true;
                }
            }

            if (Input.GetKey(KeyCode.F))
            {
                procesando.enabled = false;
                completo.enabled = true;
            }
            if (Input.GetKey(KeyCode.G))
            {
                completo.enabled = false;
                generar.enabled = true;
            }
            if (Input.GetKey(KeyCode.R))
            {
                generar.enabled = false;
                Felicita.enabled = true;
                //aqui va en canvas de game o win
                canvas_ganador_hikari.SetActive(true);
                canvas_yami_perdedor.SetActive(true);
                canvas_yamis_y_hikari.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<inventarioobjetos3H>().ibSol == false)
        {
            informacion2.enabled = true;
            BuscarSol.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        BuscarSol.enabled = false;
        depositarSol.enabled = false;
        procesando.enabled = false;
        completo.enabled = false;
        generar.enabled = false;
        Felicita.enabled = false;
        informacion2.enabled = false;
    }
}
