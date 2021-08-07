using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inversor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos3>().ibInversor = true;
            Destroy(this.gameObject);
        }
    }
}
