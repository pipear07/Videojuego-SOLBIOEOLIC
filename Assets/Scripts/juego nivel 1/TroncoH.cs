using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroncoH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<Inventarioobjetos1H>().ibTronco = true;
            Destroy(this.gameObject);
        }
    }
}
