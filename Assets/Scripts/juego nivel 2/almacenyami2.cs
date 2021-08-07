using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class almacenyami2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos2>().bPanel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<inventarioobjetos2>().bPanel = false; ;
    }
}
