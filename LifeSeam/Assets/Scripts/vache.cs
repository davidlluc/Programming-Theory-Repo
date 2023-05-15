using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vache : animal
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.2f;
        angle = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        base.Move(speed, angle);
    }
}
