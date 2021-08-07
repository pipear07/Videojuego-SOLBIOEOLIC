using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventarioobjetos2H : MonoBehaviour
{
    public Image iAspas;
    public Image iGenerador;
    public Image iBarquilla;
    public Image iBateria;
    public Image iViento;
    public Image Aspas;
    public Image Generador;
    public Image Barquilla;
    public Image Bateria;
    public Image Viento;
    public Image Panel;
    public Text Titulo;
    public Text FuncionAspas;
    public Text FuncionBarquilla;
    public Text FuncionBateria;
    public Text FuncionGenerador;
    public Text FuncionVietno;
    public bool ibAspas;
    public bool ibGenerador;
    public bool ibBarquilla;
    public bool ibBateria;
    public bool ibViento;
    public bool bAspas;
    public bool bGenerador;
    public bool bBarquilla;
    public bool bBateria;
    public bool bViento;
    public bool bPanel;
    public bool bTitulo;
    public bool bFuncionAspas;
    public bool bFuncionBarquilla;
    public bool bFuncionBateria;
    public bool bFuncionGenerador;
    public bool bFuncionVietno;

    // Start is called before the first frame update
    void Start()
    {
        ibAspas = false;
        ibGenerador = false;
        ibBarquilla = false;
        ibBateria = false;
        ibViento = false;
        bAspas = false;
        bGenerador = false;
        bBarquilla = false;
        bBateria = false;
        bViento = false;
        bPanel = false;
        bTitulo = false;
        bFuncionAspas = false;
        bFuncionBarquilla = false;
        bFuncionBateria = false;
        bFuncionGenerador = false;
        bFuncionVietno = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bPanel)
        {
            Panel.enabled = true;
            Titulo.enabled = true;
            Aspas.enabled = true;
            Generador.enabled = true;
            Barquilla.enabled = true;
            Bateria.enabled = true;
            Viento.enabled = true;
            FuncionAspas.enabled = true;
            FuncionGenerador.enabled = true;
            FuncionBarquilla.enabled = true;
            FuncionBateria.enabled = true;
            FuncionVietno.enabled = true;
        }
        else
        {
            Panel.enabled = false;
            Titulo.enabled = false;
            Aspas.enabled = false;
            Generador.enabled = false;
            Barquilla.enabled = false;
            Bateria.enabled = false;
            Viento.enabled = false;
            FuncionAspas.enabled = false;
            FuncionGenerador.enabled = false;
            FuncionBarquilla.enabled = false;
            FuncionBateria.enabled = false;
            FuncionVietno.enabled = false;
        }
        if (ibAspas)
        {
            iAspas.enabled = true;
        }
        else
        {
            iAspas.enabled = false;
        }

        if (ibGenerador)
        {
            iGenerador.enabled = true;
        }
        else
        {
            iGenerador.enabled = false;
        }
        if (ibBarquilla)
        {
            iBarquilla.enabled = true;
        }
        else
        {
            iBarquilla.enabled = false;
        }
        if (ibBateria)
        {
            iBateria.enabled = true;
        }
        else
        {
            iBateria.enabled = false;
        }
        if (ibViento)
        {
            iViento.enabled = true;
        }
        else
        {
            iViento.enabled = false;
        }
    }
}
