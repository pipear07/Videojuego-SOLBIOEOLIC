using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    enum STATES
    {
        IDLE,
        WALK,
        PODER,
        RETROCEDER
    }

    STATES currentState = STATES.IDLE;

    Animator anim;

    public float speedWalk = 5;
    public float rotacion = 100;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        checkConditions();

        makeBehaviour();

        rotar();
    }

    void checkConditions()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.R))
            {
                currentState = STATES.PODER;
            }

            else
            {
                currentState = STATES.WALK;
            }
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            currentState = STATES.RETROCEDER;
        }

        else
        {
            currentState = STATES.IDLE;
        }
    }

    void makeBehaviour()
    {
        switch (currentState)
        {
            case STATES.IDLE:
                idle();
                break;

            case STATES.WALK:
                walk();
                break;

            case STATES.PODER:
                poder();
                break;

            case STATES.RETROCEDER:
                retroceder();
                break;

            default:
                break;

        }
    }

    void idle()
    {
        anim.SetInteger("currenstate", 0);
    }

    void walk()
    {
        anim.SetInteger("currenstate", 1);
        transform.Translate(0, 0, speedWalk * Time.deltaTime);
    }

    void retroceder()
    {
        anim.SetInteger("currenstate", 1);
        transform.Translate(0, 0, -speedWalk * Time.deltaTime);
    }

    void poder()
    {
        anim.SetInteger("currenstate", 2);


    }

    void rotar()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0f, -rotacion, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0f, rotacion, 0f) * Time.deltaTime);
        }

    }
}
