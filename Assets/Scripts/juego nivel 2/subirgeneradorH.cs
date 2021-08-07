using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subirgeneradorH : MonoBehaviour
{
    public GameObject eolico;
    public Text aviso;
    public Image info;
    public Text tener;

    void Start()
    {
        aviso.enabled = false;
        info.enabled = false;
        tener.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            if (other.GetComponent<inventarioobjetos2H>().ibAspas == true && other.GetComponent<inventarioobjetos2H>().ibGenerador == true && other.GetComponent<inventarioobjetos2H>().ibBarquilla == true && other.GetComponent<inventarioobjetos2H>().ibBateria == true)
            {
                eolico.GetComponent<Animator>().SetBool("state", true);
                info.enabled = true;
                tener.enabled = true;
            }
            else
            {
                aviso.enabled = true;
                info.enabled = true;
            }
        }



    }

    private void OnTriggerExit(Collider other)
    {
        aviso.enabled = false;
        info.enabled = false;
        tener.enabled = false;
    }
}
