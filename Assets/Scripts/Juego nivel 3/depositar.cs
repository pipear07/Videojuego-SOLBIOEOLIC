using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class depositar : MonoBehaviour
{
    public Text BuscarSol;
    public Text depositarSol;
    public Text procesando;
    public Text completo;
    public Text generar;
    public Text Felicita;
    public Image informacion2;

    public GameObject canvas_ganador_yami;

    public GameObject canvas_hikari_perdedor;

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
        canvas_ganador_yami.SetActive(false);
        canvas_hikari_perdedor.SetActive(false);

    }
    void OnTriggerStay(Collider other)
    {

        if (other.name == "Yami")
        {
            if (other.GetComponent<inventarioobjetos3>().ibSol == true)
            {
                informacion2.enabled = true;
                depositarSol.enabled = true;
                if (Input.GetKey(KeyCode.T))
                {
                    other.GetComponent<inventarioobjetos3>().ibSol= false;
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
                canvas_ganador_yami.SetActive(true);
                canvas_hikari_perdedor.SetActive(true);
                canvas_yamis_y_hikari.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<inventarioobjetos3>().ibSol == false)
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
