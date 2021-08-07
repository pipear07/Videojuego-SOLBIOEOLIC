using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmacenYami : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<Inventarioobjetos1>().bPanel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Inventarioobjetos1>().bPanel = false; ;
    }
}
