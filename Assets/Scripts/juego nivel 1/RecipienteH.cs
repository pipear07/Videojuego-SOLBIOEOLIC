using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipienteH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<Inventarioobjetos1H>().ibRecipiente = true;
            Destroy(this.gameObject);
        }
    }
}
