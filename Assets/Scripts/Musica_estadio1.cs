using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica_estadio1 : MonoBehaviour
{
    public GameObject estadio;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Yami" || other.name == "Hikari_2.0")
        {
            estadio.GetComponent<AudioSource>().mute=false;
            //puerta.GetComponent<BoxCollider>().enabled=true;
        }

    }
}
