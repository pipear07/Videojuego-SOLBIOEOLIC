using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class almacenYami3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos3H>().bPanelprincipal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<inventarioobjetos3H>().bPanelprincipal = false; ;
    }
}
