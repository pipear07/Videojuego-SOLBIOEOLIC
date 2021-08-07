using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valvula: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<Inventarioobjetos1>().ibvalvula = true;
            Destroy(this.gameObject);
        }
    }
}
