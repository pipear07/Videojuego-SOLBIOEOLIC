using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //para tener acceso a la interface de usuario
using UnityEngine.SceneManagement;
public class Barra_de_vida_Enemigo : MonoBehaviour
{
   // public Image lifeiu;
    public Text Barradevida;
    float life;
    // public int posicionX = 327;
    public int posicionX;
    public float posicionY;
    public float anchoinicio;
    public float tiempo;
    void Start()
    {
        life = 300;
        tiempo = 1;
        // posicionY = lifeiu.GetComponent<RectTransform>().rect.y - 5.36f;
        // anchoinicio = lifeiu.GetComponent<RectTransform>().rect.width + 3f;
    }

    // Update is called once per frame
    void Update()
    {
        Barradevida.text = "Yogan : 300 / " + Mathf.Clamp(life, 0, 300);

        //       anchoinicio = anchoinicio - 1f;
        //     lifeiu.GetComponent<RectTransform>().sizeDelta = new Vector2(anchoinicio, posicionY);
        //   lifeiu.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, posicionX, lifeiu.GetComponent<RectTransform>().rect.width - 1f);

        if (life <= 0f)
        {
            GetComponent<Yogan_m>().muerte();
         //   tiempo++;
            if (tiempo >= 300)
            {
               // SceneManager.LoadScene("Nivel_3", LoadSceneMode.Single);
            //    SceneManager.LoadScene("Win_eolico", LoadSceneMode.Single);
            }

            // SceneManager.LoadScene("GameOver", LoadSceneMode.Single);  //aqui llamo al game over
        }
    }


    public float AplicarDañoEnemigo(float daños)
    {
        life = life - daños;
     
        //este es lifeiu.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, posicionX, lifeiu.GetComponent<RectTransform>().rect.width - daños);
        
        return life;
    }
}
