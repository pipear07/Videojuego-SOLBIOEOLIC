using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionYami : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<Inventario_Yami>().panel = true;
            other.GetComponent<Inventario_Yami>().panel3 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Inventario_Yami>().panel = false;
        other.GetComponent<Inventario_Yami>().panel3 = false;
    }
}
