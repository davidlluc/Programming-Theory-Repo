using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herbivore : animal
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();  
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("carnivore"))
        {
            escape = true;
            direction = (transform.position - other.transform.position).normalized;
            direction.y = 0;
            transform.rotation = Quaternion.LookRotation(transform.position - other.transform.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("carnivore"))
        {
            Destroy(gameObject);
        }
    }
}
