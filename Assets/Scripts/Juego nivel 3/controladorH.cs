using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos3H>().ibControlador = true;
            Destroy(this.gameObject);
        }
    }
}
