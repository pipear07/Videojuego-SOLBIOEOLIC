using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        mandardatos();
    }


    public void mandardatos()
    {
        try
        {

            MySqlConnection conexion = new MySqlConnection();
            string DataConection = "Server=198.71.230.11;Database=Loggeo;Uid=afelipearevalo;Pwd=Afam2017;Port=3306;";
            conexion.ConnectionString = DataConection;

            conexion.Open();

            int currentSpeed = Login.SharedInstance.Id_usuario;
           // String currentSpeed2 = Login.SharedInstance.Usuario_encapsulado;
         //   String currentSpeed3 = Login.SharedInstance.Contra_encapsulado;
            //Almacen1 = GameObject.;

          //  int currentSpeed_2 = Login.SharedInstance2.Id_usuario2;
          //  String currentSpeed2_2 = Login.SharedInstance3.Usuario_encapsulado2;
          //  String currentSpeed3_2 = Login.SharedInstance4.Contra_encapsulado2;


            Debug.Log("el id usuario #2 es " + currentSpeed);

            //MySqlCommand comando = new MySqlCommand("INSERT INTO `Informaciones`( `id_usuario`, `hora_ingreso`, `tiempo_jugando`, `numero_golpes`) VALUES (7,13:09:23,03:22:24,33);", conexion);

            // MySqlDataReader ejecute;

            // ejecute = comando.ExecuteReader();






        }
        catch (MySqlException error)
        {
            Debug.Log(" no funcinaa " + error);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IraControles()
    {
        SceneManager.LoadScene("Controles", LoadSceneMode.Single);
    }

    public void IraJugar()
    {
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
    }
    public void IraInformacion()
    {
        SceneManager.LoadScene("Informacion", LoadSceneMode.Single);
    }
    public void IraCreditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }
    public void IraMenu ()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
