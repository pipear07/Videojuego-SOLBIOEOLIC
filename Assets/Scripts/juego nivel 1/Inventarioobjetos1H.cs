using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventarioobjetos1H : MonoBehaviour
{
    public Image ivalvula;
    public bool ibvalvula;

    public Image iRecipiente;
    public bool ibRecipiente;

    public Image iTanque;
    public bool ibTanque;

    public Image iTronco;
    public bool ibTronco;

    public Text FuncionTroco;
    public Text FuncionValvula;
    public Text FuncionTanque;
    public Text FuncionRecipiente;
    public Image Tronco;
    public Image Panel;
    public Text Titulo;
    public Image Valvula;
    public Image Recipiente;
    public Image tanque;
    public bool bFuncionTronco;
    public bool bFuncionValvula;
    public bool bFuncionTanque;
    public bool bFuncionRecipiente;
    public bool bTronco;
    public bool bPanel;
    public bool btitulo;
    public bool bValvula;
    public bool bRecipiente;
    public bool bTanque;
    // Start is called before the first frame update
    void Start()
    {
        bFuncionTronco = false;
        bFuncionValvula = false;
        bFuncionTanque = false;
        bFuncionRecipiente = false;
        bTronco = false;
        bPanel = false;
        btitulo = false;
        bValvula = false;
        bRecipiente = false;
        bTanque = false;

        ibvalvula = false;
        ibRecipiente = false;
        ibTanque = false;
        ibTronco = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (bPanel)
        {
            Panel.enabled = true;
            Titulo.enabled = true;
            FuncionRecipiente.enabled = true;
            FuncionTroco.enabled = true;
            FuncionValvula.enabled = true;
            FuncionTanque.enabled = true;
            Tronco.enabled = true;
            Valvula.enabled = true;
            Recipiente.enabled = true;
            tanque.enabled = true;

        }
        else
        {
            Panel.enabled = false;
            Titulo.enabled = false;
            FuncionRecipiente.enabled = false;
            FuncionTroco.enabled = false;
            FuncionValvula.enabled = false;
            FuncionTanque.enabled = false;
            Tronco.enabled = false;
            Valvula.enabled = false;
            Recipiente.enabled = false;
            tanque.enabled = false;
        }

        if (ibvalvula)
        {
            ivalvula.enabled = true;
        }
        else
        {
            ivalvula.enabled = false;
        }

        if (ibTronco)
        {
            iTronco.enabled = true;
        }
        else
        {
            iTronco.enabled = false;
        }

        if (ibRecipiente)
        {
            iRecipiente.enabled = true;
        }
        else
        {
            iRecipiente.enabled = false;
        }

        if (ibTanque)
        {
            iTanque.enabled = true;
        }
        else
        {
            iTanque.enabled = false;
        }
    }
}
