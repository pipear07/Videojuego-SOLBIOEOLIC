using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VientoH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos2H>().ibViento = true;
            Destroy(this.gameObject);
        }
    }
}
