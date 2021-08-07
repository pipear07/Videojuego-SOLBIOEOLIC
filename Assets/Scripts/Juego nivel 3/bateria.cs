using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bateria : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos3>().ibBateria = true;
            Destroy(this.gameObject);
        }
    }
}
