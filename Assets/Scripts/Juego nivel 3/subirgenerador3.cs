using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subirgenerador3 : MonoBehaviour
{
    //public GameObject solar;
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
            if (other.GetComponent<inventarioobjetos3>().ibPaneles == true && other.GetComponent<inventarioobjetos3>().ibInversor == true && other.GetComponent<inventarioobjetos3>().ibControlador == true && other.GetComponent<inventarioobjetos3>().ibBateria == true)
            {
                //solar.GetComponent<Animator>().SetBool("state", true);
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
