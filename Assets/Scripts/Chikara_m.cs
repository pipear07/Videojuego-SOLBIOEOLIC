using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chikara_m : MonoBehaviour
{
    // Start is called before the first frame update
    #region Propiedades
    enum STATES
    {
        reposo,
        Caminar_Reposo1,
        Reposo_Caminar1,
        Atacar_Caminar1,
        Caminar_Atacar1,
        Reposo_Atacar1,
        Atacar_Reposo1,
        Caminar_Reposo2,
        Reposo_Caminar2,
        Atacar_Caminar2,
        Caminar_Atacar2,
        Reposo_Atacar2,
        Atacar_Reposo2,
    }

    STATES currentstate=STATES.reposo;

    public GameObject enemigo;
    NavMeshAgent agent; //el plano debe ser static, despues le da en cocinar para que crea el plano azul para que se mueva
    public GameObject character_1;
    public GameObject character_2;
    public float cont = 1;

    public float distancia_actual_1;
    public float distancia_para_seguirlo_1;
    public float distancia_actual_2;
    public float distancia_para_seguirlo_2;
    public bool atacar;
    public bool activar_dragon;
    #endregion

    #region Metodos del Motor
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //character_1 = GameObject.Find("Hikari_2.0");
        //  character_2 = GameObject.Find("Yami");
        // StartCoroutine("ataquegiratorio");
        //  InvokeRepeating("nana", 5f, 200f);
        cont = 1;
        atacar = false;
        activar_dragon = false;
    }


    // Update is called once per frame
    void Update()
    {
        checkConditions(); //tomar la desicion del estado para el enemigo
        makeBehaviour();//segun esa decision llamar la implementacion de cada estado
                        //   nana();
        cont = cont * Time.deltaTime;
    }
    #endregion

    #region Metodos Propios (Inventados)
    void checkConditions()
    {
        //el vector 3 tiene x,y,z, entro a la definicion de la clase. y sobre eso tenemos unas funciones, la funcion distance

        distancia_actual_1 = Vector3.Distance(transform.position, character_1.transform.position);
        distancia_actual_2 = Vector3.Distance(transform.position, character_2.transform.position);

        //el transform.position es la posicion del enemigo y la otra del personaje
        //la variable character es el personaje inicializado, entro al componenete meshrender para acceder al color

        if (activar_dragon == true)
        {

            if (distancia_actual_1 < distancia_actual_2)
            {//HIKARI

                if (distancia_actual_1 - 10 <= distancia_para_seguirlo_1)
                {

                    currentstate = STATES.Caminar_Atacar1;
                    atacar = true;
                }
                else
                {

                    if (currentstate == STATES.reposo || currentstate == STATES.Reposo_Caminar1)
                    {
                        currentstate = STATES.Reposo_Caminar1;
                    }
                    else
                    {
                        currentstate = STATES.Atacar_Caminar1;
                        atacar = false;
                    }
                }

            }
            else
            {//YAMI
                if (distancia_actual_2 - 10 <= distancia_para_seguirlo_2)
                {

                    currentstate = STATES.Caminar_Atacar2;
                    atacar = true;
                }
                else
                {

                    if (currentstate == STATES.reposo || currentstate == STATES.Reposo_Caminar2)
                    {
                        currentstate = STATES.Reposo_Caminar2;
                    }
                    else
                    {
                        currentstate = STATES.Atacar_Caminar2;
                        atacar = false;
                    }
                }
            }

        }
        else
        {
            currentstate = STATES.reposo;
        }

       






        /*
         *  if (distancia_actual_1 <= distancia_para_seguirlo_1)
            {
                currentstate = STATES.Reposo_Caminar1;
            }
            else
            {
            if (distancia_actual_1 >= distancia_para_seguirlo_1)
            {
                currentstate = STATES.Caminar_Reposo1;
            }
                
            if (distancia_actual_2 <= distancia_para_seguirlo_2)
            {
                currentstate = STATES.Reposo_Caminar2;
            }
            else
            {
                currentstate = STATES.Caminar_Reposo2;
            }
        }

            */




    }

    void makeBehaviour() //validamos las condiciones del estado
    {
        switch (currentstate)
        {
            case STATES.reposo:
                reposo();
                break;
            case STATES.Reposo_Atacar1:
                reposo_atacar1();
                break;
            case STATES.Reposo_Atacar2:
                reposo_atacar2();
                break;
            case STATES.Atacar_Reposo1:
                atacar_reposo();
                break;
            case STATES.Atacar_Reposo2:
                atacar_reposo2();
                break;
            case STATES.Atacar_Caminar1:
                atacar_caminar();
                break;
            case STATES.Atacar_Caminar2:
                atacar_caminar2();
                break;
            case STATES.Caminar_Atacar1:
                caminar_atacar();
                break;
            case STATES.Caminar_Atacar2:
                caminar_atacar2();
                break;
            case STATES.Caminar_Reposo1:
                caminar_reposo1();
                break;
            case STATES.Caminar_Reposo2:
                caminar_reposo2();
                break;
            case STATES.Reposo_Caminar1:
                reposo_caminar();
                break;
            case STATES.Reposo_Caminar2:
                reposo_caminar2();
                break;
            
           
            default:
                break;
        }
    }

    void reposo()
    {

    }

    void reposo_atacar1()
    {
        enemigo.GetComponent<Animator>().SetInteger("Estado", 5);

    }

    void reposo_atacar2()
    {


    }

    void atacar_reposo()
    {
        enemigo.GetComponent<Animator>().SetInteger("Estado", 6);
    }

    void atacar_reposo2()
    {
        enemigo.GetComponent<Animator>().SetInteger("Estado", 6);
    }

    void atacar_caminar()
    {
        agent.SetDestination(character_1.transform.position); //seguir al personaje
        enemigo.GetComponent<Animator>().SetInteger("Estado", 3);
    }

    void atacar_caminar2()
    {
        agent.SetDestination(character_2.transform.position); //seguir al personaje
        enemigo.GetComponent<Animator>().SetInteger("Estado", 3);
    }

    void caminar_atacar()
    {
        enemigo.GetComponent<Animator>().SetInteger("Estado", 4);
    }

    void caminar_atacar2()
    {
        enemigo.GetComponent<Animator>().SetInteger("Estado", 4);
    }

    void caminar_reposo1()
    {
        enemigo.GetComponent<Animator>().SetInteger("Estado", 1);

    }


    void caminar_reposo2()
    {
        enemigo.GetComponent<Animator>().SetInteger("Estado", 1);
    }

    void reposo_caminar()
    {

        agent.SetDestination(character_1.transform.position); //seguir al personaje
        enemigo.GetComponent<Animator>().SetInteger("Estado", 2);
        //  anim.SetInteger("currenstate", 6);
    }

    void reposo_caminar2()
    {

        agent.SetDestination(character_2.transform.position); //seguir al personaje
        enemigo.GetComponent<Animator>().SetInteger("Estado", 2);
        //anim.SetInteger("currenstate", 2);                   //  anim.SetInteger("currenstate", 6);
    }

    public void muerte()
    {


        enemigo.GetComponent<Animator>().SetInteger("Estado", 7);
        //anim.SetInteger("currenstate", 2);                   //  anim.SetInteger("currenstate", 6);
    }

    IEnumerator ataquegiratorio()
    {
        for (int i = 0; i < 200; i++)
        {
            float acumulador = 200;
            acumulador = acumulador + 200;
            agent.transform.Rotate(0, acumulador, 0); //seguir al personaje
        }

        yield return new WaitForSeconds(19f);
    }

    void nana()
    {

        if (cont > 20)
        {
            for (int i = 0; i < 200; i++)
            {
                float acumulador = 200;
                acumulador = acumulador + 200;
                agent.transform.Rotate(0, acumulador, 0); //seguir al personaje
            }
            cont = 1;
        }

    }
    #endregion
}
