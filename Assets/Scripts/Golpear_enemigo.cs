﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpear_enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public float daño;
    public bool interruptor1;
    public bool interruptor2;
    public GameObject enemigo;

    private void Start()
    {
        interruptor1 = false;
        interruptor2 = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            if (other.GetComponent<Movimiento_Hikari>().golpe == true && interruptor1 == false)
            {
                enemigo.GetComponent<Barra_de_vida_Enemigo>().AplicarDañoEnemigo(daño);
                interruptor1 = true;
            }
            //error corregido, ahora falta la barra de vida
            if (other.GetComponent<Movimiento_Hikari>().golpe == false)
            {
                interruptor1 = false;
            }

        }

        if (other.name == "Yami")
        {
            if (other.GetComponent<Movimiento_Yami>().golpe == true && interruptor2 == false)
            {
                enemigo.GetComponent<Barra_de_vida_Enemigo>().AplicarDañoEnemigo(daño);
                interruptor2 = true;
            }
            //error corregido, ahora falta la barra de vida
            if (other.GetComponent<Movimiento_Yami>().golpe == false)
            {
                interruptor2 = false;
            }

        }

    }
}
