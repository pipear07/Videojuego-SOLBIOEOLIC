using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspasH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos2H>().ibAspas = true;
            Destroy(this.gameObject);
        }
    }
}
