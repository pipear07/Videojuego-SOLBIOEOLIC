using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aspas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<inventarioobjetos2>().ibAspas= true;
            Destroy(this.gameObject);
        }
    }
}
