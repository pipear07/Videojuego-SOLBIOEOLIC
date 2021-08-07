using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositarH : MonoBehaviour
{
    public Text poner;
    public Text depositar;
    public Text listo;
    public Text Abrir;
    public Text Buscar;
    public Image informacion;
    public Text buscarvalvula;
    void Start()
    {
        poner.enabled = false;
        depositar.enabled = false;
        listo.enabled = false;
        Abrir.enabled = false;
        Buscar.enabled = false;
        informacion.enabled = false;
        buscarvalvula.enabled = false;

    }
    void OnTriggerStay(Collider other)
    {

        if (other.name == "Hikari_2.0")
        {
            if (other.GetComponent<Inventarioobjetos1H>().ibTronco == true)
            {
                informacion.enabled = true;
                poner.enabled = true;
                if (Input.GetKey(KeyCode.J))
                {
                    other.GetComponent<Inventarioobjetos1H>().ibTronco = false;
                    depositar.enabled = true;
                    poner.enabled = false;
                }
            }

            if (Input.GetKey(KeyCode.N))
            {
                depositar.enabled = false;
                listo.enabled = true;
            }
            if (Input.GetKey(KeyCode.M))
            {
                listo.enabled = false;
                Buscar.enabled = false;
                buscarvalvula.enabled = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {




        if (other.GetComponent<Inventarioobjetos1H>().ibTronco == false)
        {
            informacion.enabled = true;
            Buscar.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        poner.enabled = false;
        listo.enabled = false;
        Abrir.enabled = false;
        Buscar.enabled = false;
        informacion.enabled = false;
        buscarvalvula.enabled = false;
    }
}
