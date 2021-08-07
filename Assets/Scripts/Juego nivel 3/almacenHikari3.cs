using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class almacenHikari3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos3H>().bPanelprincipal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<inventarioobjetos3H>().bPanelprincipal = false; ;
    }
}
