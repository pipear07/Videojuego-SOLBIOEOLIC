using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<Inventarioobjetos1>().ibTanque = true;
            Destroy(this.gameObject);
        }
    }
}
