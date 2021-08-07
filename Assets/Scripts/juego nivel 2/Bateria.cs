using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos2>().ibBateria = true;
            Destroy(this.gameObject);
        }
    }
}
