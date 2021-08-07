using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] audios;
    AudioSource audio1;
    AudioSource audio2;
    void Start()
    {
        audio1 = GetComponent<AudioSource>();
        audio1.clip = audios[0];
        audio1.Play();

       // audio2 = GetComponent<AudioSource>();
      //  audio2.clip = audios[1];
      //  audio2.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            audio1.clip = audios[1];
            audio1.Play();
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
         //   audio1.clip = audios[0];
        //    audio1.Play();
        }
    
        


    }
}
