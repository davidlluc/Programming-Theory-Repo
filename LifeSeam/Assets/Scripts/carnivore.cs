using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carnivore :animal
{
    // Start is called before the first frame update
    protected override void Start()
    {
        oldpos = transform.position;
        base.Start();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("herbivore"))
        {
            escape = true;
            direction = (-transform.position + other.transform.position).normalized;
            direction.y = 0;
            transform.LookAt(other.transform.position);
        }
    }
}
