using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos2H>().ibGenerador = true;
            Destroy(this.gameObject);
        }
    }
}
