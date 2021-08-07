using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using System.Drawing;

public class Daño_Yogan : MonoBehaviour
{
    // Start is called before the first frame update
    public float distancia = 5; //la distancia que va tener ese rayo
    public GameObject Golpe1;
    public bool interruptor1;
    public bool interruptor2;
    public GameObject efectoderoca;
    private void FixedUpdate()
    {
    
            rayo1();
        

    }

    private void Start()
    {
        //Golpe1.GetComponent<a> = false;
        interruptor1 = false;
        interruptor2 = true;
        efectoderoca.GetComponent<ParticleSystem>().Stop();
        // Golpe1.GetComponent<MeshRenderer>().enabled = false;
    }

    void rayo1()
    {
        Vector3 origen = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 direccion = transform.forward; //el forward es el vector z 
        RaycastHit hit;//encapsula lo que esta tocando el rayo, no la inicializo
                       //el hit tiene los componentes del objeto que toca


        Debug.DrawRay(origen, direccion * 5, UnityEngine.Color.blue);

        if (Physics.Raycast(origen, direccion, out hit, distancia)) //primero la posicion de x,y,z del personaje, la direccion la cual se dirige el rayo, 
        {

            if (hit.collider.name == "Yami" && interruptor1 == false)
            {
                hit.collider.GetComponent<Barra_de_vida2>().AplicarDaño(10f);
                efectoderoca.GetComponent<ParticleSystem>().Play();
              efectoderoca.GetComponent<BoxCollider>().enabled = true;
                interruptor1 = true;
            }

            if (hit.collider.GetComponent<Yogan_m>().atacar == false)
            {
                interruptor1 = false;
                efectoderoca.GetComponent<ParticleSystem>().Stop();
               efectoderoca.GetComponent<BoxCollider>().enabled = false;
                //    interruptor2 = false;
            }

           
            // hit.collider.GetComponent<Barra_de_vida>().AplicarDaño(10f);



            /*
            if (hit.collider.name == "Hikari_2.0" && interruptor2==true)
            {
                hit.collider.GetComponent<Barra_de_vida>().AplicarDaño(10f);
                interruptor2 = false;
            }
            */


            //  Debug.Log("esta tocando algo");
            //   Destroy(hit.collider.gameObject);  //el hit tiene los componentes del objeto que toca
        }
    }
}
