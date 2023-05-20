using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loup : carnivore
{
    // Start is called before the first frame update
    private GameObject wolf;
    private int numberofpastebeforeclone;
    private Rigidbody rbloup;
   
    

    protected override void Start()
    {
        lifelaps = 8;
        numberofpastebeforeclone = 3;
        speed = 4.0f;
        InvokeRepeating("setlife", 4, 6);
        wolf = this.gameObject;
        rbloup=GetComponent<Rigidbody>();
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movepos = transform.position - oldpos;
        if (movepos.magnitude < 0.1f) escape = false;
        rbloup.velocity = Vector3.zero;
        rbloup.angularVelocity = Vector3.zero;
        Move(direction);
        oldpos = transform.position;
       
    }
  
    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("herbivore"))
        {
             
            escape =false;
            numberofpastebeforeclone -= 1;
            if (numberofpastebeforeclone == 0)
            {
                numberofpastebeforeclone = 3;
                Vector3 newpos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z - 1);
                GameObject t = Instantiate(wolf, newpos, transform.rotation);
                t.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

            } 

        }
    }
    private void setlife()
    {
        lifelaps -= 1;
        speed -= 0.1f;
        transform.localScale += new Vector3(0.04f, 0.04f, 0.04f);
        if (lifelaps == 0)
        {
            Destroy(gameObject);
        }

    }

}
