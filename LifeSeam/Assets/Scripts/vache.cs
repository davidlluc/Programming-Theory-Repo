using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class vache : herbivore
{
    // Start is called before the first frame update
    private GameObject cow;
    private Rigidbody rbcow;

    protected override void Start()
    {
        lifelaps = 6;
        speed = 2.0f;
        InvokeRepeating("setlife", 4, 4);
        InvokeRepeating("generate", 4, 10);
        cow = this.gameObject;
        rbcow=GetComponent<Rigidbody>();
        base.Start();

    }

    // Update is called once per frame
     void Update()
    {
       rbcow.velocity = Vector3.zero;
       rbcow.angularVelocity = Vector3.zero;   
       Move(direction);

    }
 

  

    private void setlife()
    {
       
        lifelaps -= 1;
        
       // speed -= 0.1f;
       
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
        Vector3 newpos =new  Vector3(transform.position.x - 1, transform.position.y, transform.position.z - 1);
        GameObject t = Instantiate(cow,newpos, transform.rotation);
        t.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
    }
}
