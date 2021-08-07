using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventarioobjetos3 : MonoBehaviour
{
    public Image ipaneles;
    public Image iInversor;
    public Image iControlador;
    public Image iBateria;
    public Image isol;
    public Image Panelsol;
    public Image Inversor;
    public Image Controlador;
    public Image Bateria;
    public Image sol;
    public Image Panelprincipal;
    public Text Titulo;
    public Text FuncionPanel;
    public Text FuncionInversor;
    public Text FuncionBateria;
    public Text FuncionControlador;
    public Text Funcionsol;
    public bool ibPaneles;
    public bool ibInversor;
    public bool ibControlador;
    public bool ibBateria;
    public bool ibSol;
    public bool bPanelsol;
    public bool bInversor;
    public bool bcontrolador;
    public bool bBateria;
    public bool bsol;
    public bool bPanelprincipal;
    public bool bTitulo;
    public bool bFuncionPaneles;
    public bool bFuncionInversor;
    public bool bFuncionBateria;
    public bool bFuncionControlador;
    public bool bFuncionsol;

    // Start is called before the first frame update
    void Start()
    {
        ibPaneles = false;
        ibInversor = false;
        ibControlador = false;
        ibBateria = false;
        ibSol = false;
        bPanelsol = false;
        bInversor = false;
        bcontrolador = false;
        bBateria = false;
        bsol = false;
        bPanelprincipal = false;
        bTitulo = false;
        bFuncionPaneles = false;
        bFuncionInversor = false;
        bFuncionBateria = false;
        bFuncionControlador = false;
        bFuncionsol = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bPanelprincipal)
        {
            Panelprincipal.enabled = true;
            Titulo.enabled = true;
            Panelsol.enabled = true;
            Controlador.enabled = true;
            Inversor.enabled = true;
            Bateria.enabled = true;
            sol.enabled = true;
            FuncionPanel.enabled = true;
            FuncionInversor.enabled = true;
            FuncionControlador.enabled = true;
            FuncionBateria.enabled = true;
            Funcionsol.enabled = true;
        }
        else
        {
            Panelprincipal.enabled = false;
            Titulo.enabled = false;
            Panelsol.enabled = false;
            Controlador.enabled = false;
            Inversor.enabled = false;
            Bateria.enabled = false;
            sol.enabled = false;
            FuncionPanel.enabled = false;
            FuncionInversor.enabled = false;
            FuncionControlador.enabled = false;
            FuncionBateria.enabled = false;
            Funcionsol.enabled = false;
        }
        if (ibPaneles)
        {
            ipaneles.enabled = true;
        }
        else
        {
            ipaneles.enabled = false;
        }

        if (ibInversor)
        {
            iInversor.enabled = true;
        }
        else
        {
            iInversor.enabled = false;
        }
        if (ibControlador)
        {
            iControlador.enabled = true;
        }
        else
        {
            iControlador.enabled = false;
        }
        if (ibBateria)
        {
            iBateria.enabled = true;
        }
        else
        {
            iBateria.enabled = false;
        }
        if (ibSol)
        {
            isol.enabled = true;
        }
        else
        {
            isol.enabled = false;
        }
    }
}
