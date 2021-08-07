using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subirgenerador : MonoBehaviour
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
        if (other.name == "Yami")
        {
            if (other.GetComponent<inventarioobjetos2>().ibAspas == true && other.GetComponent<inventarioobjetos2>().ibGenerador == true && other.GetComponent<inventarioobjetos2>().ibBarquilla == true && other.GetComponent<inventarioobjetos2>().ibBateria == true)
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
