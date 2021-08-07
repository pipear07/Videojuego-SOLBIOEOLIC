using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValvulaH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<Inventarioobjetos1H>().ibvalvula = true;
            Destroy(this.gameObject);
        }
    }
}
