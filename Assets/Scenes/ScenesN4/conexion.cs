using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
public class conexion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mysql();
    }

    public void Mysql()
    {
        MySqlConnection conexion = new MySqlConnection();
        string DataConection = "Server=198.71.230.11;Database=Loggeo;Uid=afelipearevalo;Pwd=Afam2017;Port=3306;";
        conexion.ConnectionString = DataConection;

        try
        {
            conexion.Open();
            Debug.Log("conexion establecida");
        }
        catch(MySqlException error2)
        {
            Debug.Log("conexion fallida"+ error2);
        }
    }
}
