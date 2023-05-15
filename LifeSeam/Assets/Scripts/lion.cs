using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lion : animal
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.0f;
        angle = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
       base.Move(speed,angle); 
    }
}
