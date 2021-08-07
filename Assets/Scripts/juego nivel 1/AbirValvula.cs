using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbirValvula : MonoBehaviour
{
    public Text abrir;
    public Image info;
    public Text felicitaciones;
    bool interruptor;
    public GameObject canvas_ganador_yami;

    public GameObject canvas_hikari_perdedor;
    
    public Canvas canvas_yamis_y_hikari;
    public GameObject luz;

    void Start()
    {
        abrir.enabled = false;
        info.enabled = false;
        felicitaciones.enabled = false;
        canvas_ganador_yami.SetActive(false);
        canvas_hikari_perdedor.SetActive(false);
        luz.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.name == "Yami")
        {
            if (Input.GetKey(KeyCode.R))
            {
                info.enabled = true;
                felicitaciones.enabled = true;
                abrir.enabled = false;
                luz.SetActive(true);
            }

            if (Input.GetKey(KeyCode.H))
            {
                interruptor = true;
                
                if (interruptor == true)
                {
                    // SceneManager.LoadScene("Nivel_3", LoadSceneMode.Single);
                    //aqui va el ganador
                    canvas_ganador_yami.SetActive(true);
                    canvas_hikari_perdedor.SetActive(true);
                    canvas_yamis_y_hikari.enabled = false;
                }
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
