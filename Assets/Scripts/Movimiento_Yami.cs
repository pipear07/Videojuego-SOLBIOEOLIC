using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System;

public class Movimiento_Yami : MonoBehaviour
{

    //#region Metodos propios (Inventados)
    //#endregion
    #region Propiedades
    Animator anim;
    bool cambio = false;
    public float caminar = 5;
    public float girar = 110;
    public float corriendo = 8;
    public float salto = 3;
    private bool interruptor = false; //para que no me repite cuando oprimo solo shilft izquierdo
    private bool interrup2 = false;
    private bool interruptor3 = false;
    public bool golpe;
    public bool sin_interrumpir;
    public float tiempo;
    public Canvas canvas_pausa;
    public Canvas canvas_escena;
    public GameObject objetovacio;
    public float contador;
    public bool validar_contador;


    private int almacen;
    private string almacen1;
    private string almacen2;
    private string almacen3;
    private string almacen4;

    enum STATES
    {
        Reposo,
        Reposo_Agacharse,
        Agacharse_Reposo,
        Agacharse_Caminar,
        Caminar_Agacharse,
        Correr_Caminar,
        Caminar_Correr,
        Reposo_Correr,
        Correr_Reposo,
        Reposo_Caminar,
        Caminar_Reposo,
        Reposo_Saltar,
        Saltar_Reposo,
        Saltar_Caminar,
        Caminar_Saltar,
        Reposo_Recoger,
        Recoger_Reposo,
        Reposo_Golpear,
        Golpear_Reposo,
        Girar_Izquierda,
        Girar_Derecha,



    }

    STATES currentState = STATES.Reposo; //AQUI ENCAPSULA

    public int Almacen { get => almacen; set => almacen = value; }
    public string Almacen1 { get => almacen1; set => almacen1 = value; }
    #endregion

    #region Metodos del Motor
    void Start()
    {
        anim = GetComponent<Animator>(); //PARA QUE ME TRAIGA TODOS LOS COMPONENTES DEL ANIMATOR
        golpe = false;
        sin_interrumpir = false;
        tiempo = 1;
        contador = 1;
        validar_contador = false;
        mandardatos();
    }

    // Update is called once per frame
    void Update()
    {
        checkcondicion();
        makeBehaviour();
        tiempo++;

    }
    #endregion

    #region Metodos propios (Inventados)

    public void mandardatos()
    {
        try
        {

            MySqlConnection conexion = new MySqlConnection();
            string DataConection = "Server=198.71.230.11;Database=Loggeo;Uid=afelipearevalo;Pwd=Afam2017;Port=3306;";
            conexion.ConnectionString = DataConection;

            conexion.Open();

            //   int currentSpeed = Login.SharedInstance.Id_usuario;
            //    String currentSpeed2 = Login.SharedInstance.Usuario_encapsulado;
            //   String currentSpeed3 = Login.SharedInstance.Contra_encapsulado;
            //Almacen1 = GameObject.;

            //  int currentSpeed_2 = Login.SharedInstance2.Id_usuario2;
            //   String currentSpeed2_2 = Login.SharedInstance3.Usuario_encapsulado2;
            //   String currentSpeed3_2 = Login.SharedInstance4.Contra_encapsulado2;


            //  Debug.Log("el usuario #2 "+currentSpeed2_2+" con el id "+currentSpeed_2+" y contraseña "+currentSpeed3_2 );
            Debug.Log(DateTime.Now.ToShortTimeString());
             MySqlCommand comando = new MySqlCommand("INSERT INTO Informaciones ( id_usuario, hora_ingreso, tiempo_jugando, numero_golpes) VALUES ('25','"+ DateTime.Now.ToShortTimeString() + ":20','00:11:58','12');", conexion);

           // MySqlCommand comando = new MySqlCommand("INSERT INTO `Informaciones`(25,'17:25:50','00:11:58',12) VALUES ({1},{2},{3},{4});", conexion);

            MySqlDataReader ejecute;

            ejecute = comando.ExecuteReader();




            conexion.Close();
            

        }
        catch (MySqlException error)
        {
            Debug.Log(" no funcinaa " + error);
        }
       
    }


    void checkcondicion()
    {
        //**************************************************************************************************
        if (sin_interrumpir == false)
        {

            if (Input.GetKey(KeyCode.W)) //W
            {

                if (currentState == STATES.Reposo || currentState == STATES.Golpear_Reposo || currentState == STATES.Recoger_Reposo)
                {
                    currentState = STATES.Reposo_Caminar;
                    interrup2 = true;
                }

                if (currentState == STATES.Correr_Caminar)
                {
                    currentState = STATES.Reposo_Caminar;
                }


                if (Input.GetKey(KeyCode.LeftControl))//caminar y saltar con control derecho
                {
                    interruptor3 = true;
                    currentState = STATES.Caminar_Saltar;
                }
                else
                {

                }

                if (Input.GetKey(KeyCode.LeftShift)) //MAS SHILF
                {
                    currentState = STATES.Caminar_Correr;
                    interruptor = true;

                }
                else
                {
                    interruptor = true;

                    if (currentState == STATES.Caminar_Correr)
                    {
                        currentState = STATES.Correr_Caminar;
                        //  interruptor3 = true
                        interrup2 = false;
                    }
                }
            }
            else
            {

                if (currentState == STATES.Reposo_Caminar)
                {
                    currentState = STATES.Caminar_Reposo;
                    interruptor = false;
                    interrup2 = true; //reposo camina
                }
                else
                {
                    if (interrup2 == true)
                    {
                        currentState = STATES.Reposo;
                        interrup2 = false;
                    }

                }


            }
            //**************************************************************************************************

            //**************************************************************************************************
            if (Input.GetKey(KeyCode.S)) //flecha abajo
            {
                // Debug.Log("Flecha abajo");
                currentState = STATES.Reposo_Agacharse;
            }
            else
            {
                if (currentState == STATES.Reposo_Agacharse)
                {
                    currentState = STATES.Agacharse_Reposo;
                    interrup2 = true;
                }
            }
            //**************************************************************************************************

            //**************************************************************************************************
            if (Input.GetKey(KeyCode.A)) //flecha izquierda
            {
                // Debug.Log("Flecha izquierda");
                currentState = STATES.Girar_Izquierda;
            }
            else
            {
                if (currentState == STATES.Girar_Izquierda)
                {
                    currentState = STATES.Reposo;
                }
            }
            //**************************************************************************************************

            //**************************************************************************************************
            if (Input.GetKey(KeyCode.D)) //flecha a la derecha
            {
                // Debug.Log("Flecha derecha");
                currentState = STATES.Girar_Derecha;
            }
            else
            {
                if (currentState == STATES.Girar_Derecha)
                {
                    currentState = STATES.Reposo;
                }
            }
            //**************************************************************************************************


            //**************************************************************************************************
            if (Input.GetKey(KeyCode.E)) //Letra P - Golpear
            {
                //  Debug.Log("Flecha derecha");
                currentState = STATES.Reposo_Golpear;
                golpe = true;
                if (validar_contador == false)
                {
                    contador = contador + 1;
                    validar_contador = true;
                }
                
            }
            else
            {
                if (currentState == STATES.Reposo_Golpear)
                {
                    currentState = STATES.Golpear_Reposo;
                    interrup2 = false;
                    golpe = false;
                    validar_contador = false;
                }



            }
            //**************************************************************************************************



            //**************************************************************************************************


            //**************************************************************************************************
            if (Input.GetKey(KeyCode.LeftControl) && interruptor3 == false) //control derecha - saltar
            {
                currentState = STATES.Reposo_Saltar;
                //Debug.Log("Control Derecho");
            }
            else
            {
                if (currentState == STATES.Reposo_Saltar)
                {
                    currentState = STATES.Saltar_Reposo;
                    interrup2 = false;
                }
            }

            //**************************************************************************************************
            if (Input.GetKey(KeyCode.LeftShift) && interruptor == false) //shilf derecho
            {
                // Debug.Log("Shilf Derecho");
                currentState = STATES.Reposo_Correr;
            }
            else
            {
                if (currentState == STATES.Reposo_Correr && interruptor == false)
                {
                    currentState = STATES.Correr_Reposo;
                }
            }

        }


        //**************************************************************************************************
        if (Input.GetKey(KeyCode.Q)) //Letra Q - Recoger
        {
            //  Debug.Log("Flecha derecha");
            tiempo = 0;
            currentState = STATES.Reposo_Recoger;
            sin_interrumpir = true;
        }
        else
        {
            if (tiempo > 45)
            {
                if (currentState == STATES.Reposo_Recoger)
                {
                    currentState = STATES.Recoger_Reposo;
                    interrup2 = false;
                    sin_interrumpir = false;
                    tiempo = 0;
                }
            }

        }


        if (Input.GetKeyDown(KeyCode.Space)) //Letra Q - Recoger
        {
           

            if (cambio == false)
            {
                cambio = !cambio;
                canvas_pausa.enabled = true;
                canvas_escena.enabled = false;
                objetovacio.GetComponent<ScriptPausa>().btnPause();
            }
            else
            {
                cambio = !cambio;
                canvas_pausa.enabled = false;
                canvas_escena.enabled = true;
                objetovacio.GetComponent<ScriptPausa>().btnReanudar();
            }

            //SceneManager.LoadScene("Pausa", LoadSceneMode.Single);
        }

       


    }

    void makeBehaviour()
    {
        switch (currentState)
        {

            case STATES.Reposo:
                reposo();
                break;
            case STATES.Reposo_Agacharse:
                reposo_agacharse();
                break;
            case STATES.Agacharse_Reposo:
                agacharse_reposo();
                break;
            case STATES.Agacharse_Caminar:
                agacharse_caminar();
                break;
            case STATES.Caminar_Agacharse:
                caminar_agacharse();
                break;
            case STATES.Correr_Caminar:
                correr_caminar();
                break;
            case STATES.Caminar_Correr:
                caminar_correr();
                break;
            case STATES.Reposo_Correr:
                reposo_correr();
                break;
            case STATES.Correr_Reposo:
                correr_reposo();
                break;
            case STATES.Reposo_Caminar:
                reposo_caminar();
                break;
            case STATES.Caminar_Reposo:
                caminar_reposo();
                break;
            case STATES.Reposo_Saltar:
                reposo_saltar();
                break;
            case STATES.Saltar_Reposo:
                saltar_reposo();
                break;
            case STATES.Saltar_Caminar:
                saltar_caminar();
                break;
            case STATES.Caminar_Saltar:
                caminar_saltar();
                break;
            case STATES.Reposo_Recoger:
                reposo_recoger();
                break;
            case STATES.Recoger_Reposo:
                recoger_reposo();
                break;
            case STATES.Reposo_Golpear:
                reposo_golpear();
                break;
            case STATES.Golpear_Reposo:
                golpear_reposo();
                break;
            case STATES.Girar_Izquierda:
                girar_izquierda();
                break;
            case STATES.Girar_Derecha:
                girar_derecha();
                break;
        }
    }
    #endregion

    #region Metodos propios (Inventados)
    void reposo()
    {
        anim.SetInteger("Estado1", 0);
    }

    void reposo_agacharse()
    {
        anim.SetInteger("Estado1", 1);
    }

    void agacharse_reposo()
    {
        anim.SetInteger("Estado1", 2);
    }

    void agacharse_caminar()
    {
        anim.SetInteger("Estado1", 3);
    }

    void caminar_agacharse()
    {
        anim.SetInteger("Estado1", 4);
    }

    void correr_caminar()
    {
        anim.SetInteger("Estado1", 5);
        transform.Translate(0, 0, caminar * Time.deltaTime);
    }

    void caminar_correr()
    {
        anim.SetInteger("Estado1", 6);
        transform.Translate(0, 0, corriendo * Time.deltaTime);
    }

    void reposo_correr()
    {
        anim.SetInteger("Estado1", 7);
        transform.Translate(0, 0, corriendo * Time.deltaTime);
    }

    void correr_reposo()
    {
        anim.SetInteger("Estado1", 8);
    }
    void reposo_caminar()
    {
        anim.SetInteger("Estado1", 9);
        transform.Translate(0, 0, caminar * Time.deltaTime);
    }
    void caminar_reposo()
    {
        anim.SetInteger("Estado1", 10);
    }
    void reposo_saltar()
    {
        anim.SetInteger("Estado1", 11);
        transform.Translate(0, salto * Time.deltaTime, 0);
    }
    void saltar_reposo()
    {
        anim.SetInteger("Estado1", 12);
    }
    void saltar_caminar()
    {
        anim.SetInteger("Estado1", 13);
    }
    void caminar_saltar()
    {
        anim.SetInteger("Estado1", 14);
        transform.Translate(0, salto * Time.deltaTime, caminar * Time.deltaTime);
    }
    void reposo_recoger()
    {
        anim.SetInteger("Estado1", 15);
    }
    void recoger_reposo()
    {
        anim.SetInteger("Estado1", 16);
    }
    void reposo_golpear()
    {
        anim.SetInteger("Estado1", 17);
    }

    void golpear_reposo()
    {
        anim.SetInteger("Estado1", 18);
    }

    void girar_derecha()
    {
        transform.Rotate(0, girar * Time.deltaTime, 0, Space.Self);
    }
    void girar_izquierda()
    {
        transform.Rotate(0, -girar * Time.deltaTime, 0, Space.Self);
    }
    #endregion

    //#region Metodos propios (Inventados)
    //#endregion
}
