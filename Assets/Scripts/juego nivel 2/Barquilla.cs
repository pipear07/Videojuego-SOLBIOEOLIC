using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barquilla : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos2>().ibBarquilla = true;
            Destroy(this.gameObject);
        }
    }
}
