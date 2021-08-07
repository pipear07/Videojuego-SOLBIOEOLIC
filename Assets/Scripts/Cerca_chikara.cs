using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using System.Drawing;

public class Cerca_chikara : MonoBehaviour
{
    public float daño;
    float tiempo;
    public bool interruptor1;
    public bool interruptor2;
    private void Start()
    {
        interruptor1 = false;
        interruptor2 = false;
        tiempo = 1;
    }

    private void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {


    }

    private void OnTriggerStay(Collider other)
    {

        if (other.name == "Yami" && interruptor1 == false)
        {
            other.GetComponent<Barra_de_vida2>().AplicarDaño(daño);
            interruptor1 = true;
        }


        if (other.name == "Hikari_2.0" && interruptor2 == false)
        {
            other.GetComponent<Barra_de_vida>().AplicarDaño(daño);
            interruptor2 = true;
        }

        tiempo++;
        if (tiempo >= 400)
        {
            if (other.name == "Yami")
            {
                interruptor1 = false;
            }

            if (other.name == "Hikari_2.0")
            {
                interruptor2 = false;
            }
            tiempo = 1;
        }
    }
}
