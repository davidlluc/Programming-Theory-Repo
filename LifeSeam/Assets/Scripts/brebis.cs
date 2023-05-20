using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class brebis : herbivore
{
    private GameObject Chicken;
    private Rigidbody Rbchick;
    protected override void  Start()
    {
        speed = 2.0f;
        lifelaps = 6;
        InvokeRepeating("setlife", 4, 4);
        InvokeRepeating("generate", 4, 10);
        Chicken = this.gameObject;
        Rbchick=GetComponent<Rigidbody>();  
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
        Rbchick.velocity = Vector3.zero;
        Rbchick.angularVelocity = Vector3.zero;
        Move(direction);


    }

    private void setlife()
    {
        lifelaps -= 1;
       
        speed -= 0.2f;
        transform.localScale += new Vector3(0.005f, 0.005f, 0.005f);
        if (lifelaps == 0)
        {
     
            Destroy(gameObject);
        }
        if (lifelaps == 4)
        {
            generate();
        }

    }
    private void generate()
    {
        Vector3 newpos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z - 1);
        GameObject t = Instantiate(Chicken, newpos, transform.rotation);
        t.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
    }
}

