using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bateriaH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos3H>().ibBateria = true;
            Destroy(this.gameObject);
        }
    }
}
