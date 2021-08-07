using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionHikari : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<Inventario_hikari>().panel = true;
            other.GetComponent<Inventario_hikari>().panel3 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Inventario_hikari>().panel = false;
        other.GetComponent<Inventario_hikari>().panel3 = false;
    }

}
