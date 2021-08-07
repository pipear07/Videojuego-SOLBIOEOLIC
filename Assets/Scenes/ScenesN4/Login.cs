using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //para tener acceso a la interface de usuario
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;
public class Login : MonoBehaviour
{
    private static Login instance = null;
    
    public static Login SharedInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new Login();
            }
            return instance;
        }
    }

 

   //public float speed=2f;

    // Start is called before the first frame update
    public Text usuario;
    public InputField experimento_usuario;
    public InputField experimento;
    public InputField mensaje;
    bool valida_usuario1;
    bool valida_usuario2;

    public string convertir1;
    public string convertir2;

    private int id_usuario;
    private static string usuario_encapsulado;
    private string contra_encapsulado;

    private int id_usuario2;
    private string usuario_encapsulado2;
    private string contra_encapsulado2;

    private int almacenaje;
    private string almacenaje1;
    private string almacenaje2;

    

    public string Usuario_encapsulado { get => usuario_encapsulado; set => usuario_encapsulado = value; }
    public string Contra_encapsulado { get => contra_encapsulado; set => contra_encapsulado = value; }
    public string Usuario_encapsulado2 { get => usuario_encapsulado2; set => usuario_encapsulado2 = value; }
    public string Contra_encapsulado2 { get => contra_encapsulado2; set => contra_encapsulado2 = value; }
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    public int Almacenaje { get => almacenaje; set => almacenaje = value; }
    public string Almacenaje1 { get => almacenaje1; set => almacenaje1 = value; }
    public string Almacenaje2 { get => almacenaje2; set => almacenaje2 = value; }
    public int Id_usuario2 { get => id_usuario2; set => id_usuario2 = value; }

    void Start()
    {
        Debug.Log("holi");
         mensaje.enabled = false;
        // contraseña = Text.c
        //  convertir2 = InputField.ContentType.Standard;
        valida_usuario1 = false;
        valida_usuario2 = true;
    }

    public void registrate()
    {
     //   Response.Redirect("https://www.arevalo2013.com/Registro.php");
        System.Diagnostics.Process.Start("https://www.arevalo2013.com/Registro.php");
    }

    //PARA MOSTRAR EN EL FORMULARIO
    public void iniciarsesion()
    {
        experimento.contentType = InputField.ContentType.Standard;
        // Debug.Log("ell usuario es:  " + (usuario.GetComponent<Text>().text).ToString() + contraseña);
        convertir1 = (usuario.GetComponent<Text>().text).ToString();
        convertir2 = (experimento.text).ToString();
     
        experimento.contentType = InputField.ContentType.Password;

        try
        {
            MySqlConnection conexion = new MySqlConnection();
            string DataConection = "Server=198.71.230.11;Database=Loggeo;Uid=afelipearevalo;Pwd=Afam2017;Port=3306;";
            conexion.ConnectionString = DataConection;

            conexion.Open();

            MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuarios where usuario LIKE " +"'"+ convertir1 + "'" + " AND contrase LIKE "+"'"+ convertir2 + "'" + " ;", conexion);

            MySqlDataReader ejecute;

            ejecute = comando.ExecuteReader();

           


            while (ejecute.Read() )
            {

                Almacenaje = ejecute.GetInt32(0);
                Almacenaje1 = ejecute.GetString(1);
                Almacenaje2 = ejecute.GetString(2);

            }

           



           



            if (valida_usuario2 == false)
            {
                if (convertir1 == almacenaje1 && convertir2 == almacenaje2)
                {
                    Id_usuario2 = almacenaje;
                    Usuario_encapsulado2 = almacenaje1;
                    contra_encapsulado2 = almacenaje2;
                    //Debug.Log("El usuario y contraseña coinciden, bienvenido ");
                    mensaje.enabled = true;
                    mensaje.text = "El usuario y contraseña coinciden, Usuario#2 ";
                   
                    valida_usuario2 = true;
                    conexion.Close();

                    SceneManager.LoadScene("Menu", LoadSceneMode.Single);
                }



                if (convertir1 != almacenaje1 && convertir2 != almacenaje2)
                {

                    //Debug.Log("esta guardando "+Usuario_encapsulado2);
                    mensaje.enabled = true;
                    // Debug.Log("El usuario o contraseña son incorrectos");
                    mensaje.text = "El usuario o contraseña son incorrectos ";
                }
            }



            if (valida_usuario1 == false)
            {
                if (convertir1 == almacenaje1 && convertir2 == almacenaje2)
                {
                    //Debug.Log("El usuario y contraseña coinciden, bienvenido ");
                    Id_usuario = almacenaje;
                    usuario_encapsulado = almacenaje1;
                    contra_encapsulado = almacenaje2;

                    mensaje.enabled = true;
                    mensaje.text = "El usuario y contraseña coinciden, Usuario#1 ";
                    valida_usuario1 = true;
                    valida_usuario2 = false;
                    experimento_usuario.text = "";
                    experimento.text = "";
                   // usuario.text = "k";
                   //  experimento.text = "";
                }



                if (convertir1 != almacenaje1 && convertir2 != almacenaje2)
                {
                    mensaje.enabled = true;
                    // Debug.Log("El usuario o contraseña son incorrectos");
                    mensaje.text = "El usuario o contraseña son incorrectos ";
                }
            }







        }
        catch (MySqlException error)
        {
            Debug.Log(" no funcinaa "+error);
        }

        


    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(contraseña.text);
    }
}
