using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Depositar2 : MonoBehaviour
{
    public GameObject rotaraspas;
    public GameObject rotaraspas1;
    public GameObject rotaraspas2;
    public GameObject luz;
    public GameObject luz1;
    public GameObject luz2;
    public GameObject luz3;
    public Text BuscarViento;
    public Text depositarviento;
    public Text procesando;
    public Text completo;
    public Text generar;
    public Text Felicita;
    public Image informacion2;
    public GameObject canvas_ganador;

    public GameObject canvas_hikari_perdedor;
    public float tiempo;
    public Image Barradevida;
    public Text Numerodevida;
    public Image Carcasa_de_vida;
    public float life;
    public Canvas canvas_yamis_y_hikari;
    bool interruptor;
    void Start()
    {
        BuscarViento.enabled = false;
        depositarviento.enabled = false;
        procesando.enabled = false;
        completo.enabled = false;
        generar.enabled = false;
        Felicita.enabled = false;
        informacion2.enabled = false;
        luz.SetActive(false);
        luz1.SetActive(false);
        luz2.SetActive(false);
        luz3.SetActive(false);
        canvas_ganador.SetActive(false);
        canvas_hikari_perdedor.SetActive(false);
        tiempo = 1;
        interruptor = false;

    }
    void OnTriggerStay(Collider other)
    {

        if (other.name == "Yami")
        {
            if (other.GetComponent<inventarioobjetos2>().ibViento == true)
            {
                informacion2.enabled = true;
                depositarviento.enabled = true;
                if (Input.GetKey(KeyCode.T))
                {
                    other.GetComponent<inventarioobjetos2>().ibViento = false;
                    rotaraspas.GetComponent<Animator>().SetBool("state", true);
                    rotaraspas1.GetComponent<Animator>().SetBool("state", true);
                    rotaraspas2.GetComponent<Animator>().SetBool("state", true);
                    depositarviento.enabled = false;
                    procesando.enabled = true;
                }
            }

            if (Input.GetKey(KeyCode.F))
            {
                procesando.enabled = false;
                completo.enabled = true;
            }
            if (Input.GetKey(KeyCode.G))
            {
                completo.enabled = false;
                generar.enabled = true;
                luz.SetActive(true);
                luz1.SetActive(true);
                luz2.SetActive(true);
                luz3.SetActive(true);
            }
            if( Input.GetKey(KeyCode.R))
            {
                generar.enabled = false;
                Felicita.enabled = true;
                
                interruptor = true;
                
            }



            tiempo++;
            if (tiempo >= 100 && interruptor==true)
            {
                // SceneManager.LoadScene("Nivel_3", LoadSceneMode.Single);
                Numerodevida.enabled = false;
                Carcasa_de_vida.enabled = false;
                Barradevida.enabled = false;
                canvas_ganador.SetActive(true);
                canvas_hikari_perdedor.SetActive(true);
                canvas_yamis_y_hikari.enabled = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<inventarioobjetos2>().ibViento == false)
        {
            informacion2.enabled = true;
            BuscarViento.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        BuscarViento.enabled = false;
        depositarviento.enabled = false;
        procesando.enabled = false;
        completo.enabled = false;
        generar.enabled = false;
        Felicita.enabled = false;
        informacion2.enabled = false;
    }
}
