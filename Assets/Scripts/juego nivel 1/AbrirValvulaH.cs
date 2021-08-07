using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbrirValvulaH : MonoBehaviour
{
    public Text abrir;
    public Image info;
    public Text felicitaciones;
    public GameObject canvas_ganador_hikari;

    public GameObject canvas_yami_perdedor;

    public Canvas canvas_yamis_y_hikari;
    public GameObject luz;

    void Start()
    {
        abrir.enabled = false;
        info.enabled = false;
        felicitaciones.enabled = false;
        canvas_ganador_hikari.SetActive(false);
        canvas_yami_perdedor.SetActive(false);
        luz.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.name == "Hikari_2.0")
        {
            if (Input.GetKey(KeyCode.H))
            {
                info.enabled = true;
                felicitaciones.enabled = true;
                abrir.enabled = false;
                luz.SetActive(true);
            }

            if (Input.GetKey(KeyCode.L))
            {
                //aqui va en canvas de game o win
                canvas_ganador_hikari.SetActive(true);
                canvas_yami_perdedor.SetActive(true);
                canvas_yamis_y_hikari.enabled = false;
            }

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        abrir.enabled = true;
        info.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        info.enabled = false;
        felicitaciones.enabled = false;
    }
}
