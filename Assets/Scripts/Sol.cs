using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sol : MonoBehaviour
{
    // Start is called before the first frame update
    public Light luz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        luz.transform.Rotate(2*Time.deltaTime, 2*Time.deltaTime, 0);
    }
}
