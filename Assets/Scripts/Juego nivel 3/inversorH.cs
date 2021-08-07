using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inversorH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos3H>().ibInversor = true;
            Destroy(this.gameObject);
        }
    }
}
