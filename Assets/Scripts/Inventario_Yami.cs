using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario_Yami : MonoBehaviour
{
    public bool panel3; // Variable para activar o desactivar el panel de la informacion de la mision del nivel 1
    public bool panel;  //variable para activar o descativar el panel del biogenerador nivel 1
    public Image panel2; //variale para el manejo del panel de la imagen de la informacion nivel 1
    public Image panel1; //variale para el manejo del panel de la imagen del biogenrador nivel 1
    public Text informacion1; // variable para habilitar o deshabilitar el texto informativo de hikari (mision) nivel 1
    public GameObject espada;
    //public bool llave; //defina una variable de tipo booleana
  //  public Image llave1; //defina una variable tipo imagen para la foto de la llave, y arrastrarla al editor para que la inicialice
    // Start is called before the first frame update
    void Start()
    {

    //    llave = false; //comience con la variable llave en falso, porque no la tengo aun
        espada = GameObject.Find("Espada_legendaria_yami"); //asi se inicializa los objetos directamente
        espada.SetActive(false);
        panel = false;  // se inicializa en falso para que no se ejecute al iniciar el juego nivel 1
        panel3 = false; // se inicializa en falso para que no se ejecute al iniciar el juego nivel 1
        informacion1.enabled = false; //se inicializa en falso para que no se ejecute al iniciar el juego nivel 1
    }

    // Update is called once per frame
    void Update() //este metodo siempre se ejecutara en el personaje
    {
        // se validan los estados de cada variable que se generan en el script mision hikari
        // Estas opciones habilitan y deshabilitan los paneles y las imagnes en el canvas en el nivel 1

        if (panel)
        {
            panel1.enabled = true;
        }
        else
        {
            panel1.enabled = false;
        }
        if (panel3)
        {
            panel2.enabled = true;
            informacion1.enabled = true;
        }
        else
        {
            panel2.enabled = false;
            informacion1.enabled = false;
        }
    }

    public void activar_espada(bool obtener)
    {
        espada.SetActive(obtener);
    }
}
