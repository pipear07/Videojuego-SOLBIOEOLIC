using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almacenhikari : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<Inventarioobjetos1H>().bPanel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Inventarioobjetos1H>().bPanel = false; ;
    }
}
