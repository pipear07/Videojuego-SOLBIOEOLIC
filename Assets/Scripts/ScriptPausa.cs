using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPausa : MonoBehaviour
{
    public static bool gameP;
    public static bool boolseguroP;
    public Canvas canvas_pausa;
    public Canvas canvas_escena;
   
    public GameObject menuP, seguroP;

       
    private void Start()
    {
        canvas_pausa.enabled = false;
        //menuP.SetActive(false);
     //   seguroP.SetActive(false);
      
    }

    private void Update()
    {
      //  SwitchPause();
    }

    // Update is called once per frame
    public void SwitchPause()
    {
        if (gameP)
        {
            btnReanudar();
        }

        else
        {
            btnPause();
        }
    }


    public void btnReanudar()
    {
    //    menuP.SetActive(false);
        Time.timeScale = 1;
        gameP = false;
        
        canvas_escena.enabled = true;
        canvas_pausa.enabled = false;
        //  SceneManager.LoadScene("Nivel_2");

    }

    public void btnPause()
    {
        //    menuP.SetActive(true);
        canvas_escena.enabled = false;
        canvas_pausa.enabled = true;
        Time.timeScale = 0;
        gameP = true;
    }


    public void Menu_principal ()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void panel2()
    {
       // seguroP.SetActive(true);
    }


    public void salirPno()
    {
      //  seguroP.SetActive(false);
    }


    public void salirPsi()
    {
        Debug.Log("se ha salido del juego");
        Application.Quit();
    }


}
