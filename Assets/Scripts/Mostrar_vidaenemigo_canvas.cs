using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mostrar_vidaenemigo_canvas : MonoBehaviour
{
    // Start is called before the first frame update
    public Text vida;
    public Image fondo;
    public GameObject enemigo;
    public GameObject enemigo2;
    public GameObject enemigo3;
    public GameObject puerta;
    void Start()
    {
        fondo.enabled = false;
        vida.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.name=="Yami" || other.name == "Hikari_2.0")
        {
            fondo.enabled = true;
            vida.enabled = true;
            enemigo.GetComponent<Chikara_m>().activar_dragon = true;
            enemigo2.GetComponent<Chikara_m>().activar_dragon = true;
            enemigo3.GetComponent<Chikara_m>().activar_dragon = true;
            puerta.GetComponent<Animator>().SetInteger("Estado", 1);

            //puerta.GetComponent<BoxCollider>().enabled=true;
        }

    }
}
