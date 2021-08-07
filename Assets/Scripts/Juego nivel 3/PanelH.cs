using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelH : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<inventarioobjetos3H>().ibPaneles = true;
            Destroy(this.gameObject);
        }
    }
}
