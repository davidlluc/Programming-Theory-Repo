using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brebis : animal
{
    
    void Start()
    {
       
        speed = 1.0f;
        angle = 45.0f;
       
       
    }

    // Update is called once per frame
    void Update()
    {
        base.Move(speed, angle);
    }
    private void OnTriggerEnter(Collider other)
    {
        //print(other.name);
    }
}

