using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //para tener acceso a la interface de usuario

public class Espada : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yami")
        {
            other.GetComponent<Inventario_Yami>().activar_espada(true);
            Destroy(this.gameObject);
        }

        if (other.name == "Hikari_2.0")
        {
            other.GetComponent<Inventario_hikari>().activar_espada(true);
            Destroy(this.gameObject);
        }
    }
}
