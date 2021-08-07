﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subirBiodigestorH : MonoBehaviour
{

    public GameObject biodigestor;
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
            if (other.GetComponent<Inventarioobjetos1H>().ibRecipiente == true && other.GetComponent<Inventarioobjetos1H>().ibTanque == true && other.GetComponent<Inventarioobjetos1H>().ibvalvula == true)
            {
                biodigestor.GetComponent<Animator>().SetBool("state", true);
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
