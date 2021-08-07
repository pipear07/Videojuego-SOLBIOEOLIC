using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipiente : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<Inventarioobjetos1>().ibRecipiente = true;
            Destroy(this.gameObject);
        }
    }
}
