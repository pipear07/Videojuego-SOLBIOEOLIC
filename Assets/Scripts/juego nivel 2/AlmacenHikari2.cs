using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmacenHikari2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos2H>().bPanel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<inventarioobjetos2H>().bPanel = false; ;
    }
}
