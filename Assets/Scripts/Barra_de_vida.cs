using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //para tener acceso a la interface de usuario
using UnityEngine.SceneManagement;
using System;

public class Barra_de_vida : MonoBehaviour
{
    public GameObject canvaspierde;
    public Image lifeiu;
    public Text simbolovida;
    float life;
    // public int posicionX = 327;
    public int posicionX;
    public float posicionY;
    public float anchoinicio;
    public GameObject personaje;
    void Start()
    {
        life = 200;
        posicionY = lifeiu.GetComponent<RectTransform>().rect.y-5.36f;
        anchoinicio = lifeiu.GetComponent<RectTransform>().rect.width+3f;
        canvaspierde.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        simbolovida.text = "200 / " + Mathf.Clamp(life,0,200);
 
 //       anchoinicio = anchoinicio - 1f;
   //     lifeiu.GetComponent<RectTransform>().sizeDelta = new Vector2(anchoinicio, posicionY);
     //   lifeiu.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, posicionX, lifeiu.GetComponent<RectTransform>().rect.width - 1f);
       
        if (life < 0f)
        {
            canvaspierde.SetActive(true);
            Destroy(personaje);
            lifeiu.enabled = false;
            simbolovida.enabled = false;
            //SceneManager.LoadScene(canvaspierde, LoadSceneMode.Single);  //aqui llamo al game over
            //   SceneManager.LoadScene("GameOverBiomasa", LoadSceneMode.Single);  //aqui llamo al game over
            //canvaspierde.
        }
    }


    public float AplicarDaño(float daños)
    {
        life = life - daños;
       // anchoinicio = anchoinicio - 1f;
       // lifeiu.GetComponent<RectTransform>().sizeDelta = new Vector2(anchoinicio, posicionY);
        lifeiu.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, posicionX, lifeiu.GetComponent<RectTransform>().rect.width-daños);
       // lifeiu.fillAmount -= 1.0f / 10.0f * Time.deltaTime;
        return life;
    }
}
