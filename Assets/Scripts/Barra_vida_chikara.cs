using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //para tener acceso a la interface de usuario
using UnityEngine.SceneManagement;

public class Barra_vida_chikara : MonoBehaviour
{
    // public Image lifeiu;
    public Text Barradevida;
    float life;
    // public int posicionX = 327;
    public int posicionX;
    public float posicionY;
    public float anchoinicio;
    public float tiempo;
    public GameObject enemigo;
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
        Barradevida.text = "Chikara : 300 / " + Mathf.Clamp(life, 0, 300);

        //       anchoinicio = anchoinicio - 1f;
        //     lifeiu.GetComponent<RectTransform>().sizeDelta = new Vector2(anchoinicio, posicionY);
        //   lifeiu.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, posicionX, lifeiu.GetComponent<RectTransform>().rect.width - 1f);

        if (life <= 0f)
        {
            enemigo.GetComponent<Chikara_m>().activar_dragon = false;
            enemigo.GetComponent<Chikara_m>().muerte();
            tiempo++;
            if (tiempo >= 300)
            {
                SceneManager.LoadScene("Win_biomasa", LoadSceneMode.Single);
            }

            //SceneManager.LoadScene("GameOverBiomasa", LoadSceneMode.Single);  //aqui llamo al game over
        }
    }


    public float AplicarDañoEnemigo(float daños)
    {
        life = life - daños;

        //este es lifeiu.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, posicionX, lifeiu.GetComponent<RectTransform>().rect.width - daños);

        return life;
    }
}
