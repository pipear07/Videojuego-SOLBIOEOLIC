using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viento : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos2>().ibViento = true;
            Destroy(this.gameObject);
        }
    }
}
