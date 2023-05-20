using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class lion : carnivore
{
    // Start is called before the first frame update
    private int numberofpastebeforeclone;
    private GameObject Lion;
    private Rigidbody rblion;
    protected override void Start()
    {
        lifelaps = 9;
        speed = 4.0f;
        numberofpastebeforeclone = 3;
        InvokeRepeating("setlife", 4, 5);
        Lion = this.gameObject;
        rblion=GetComponent<Rigidbody>();
        base.Start();
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movepos = transform.position - oldpos;
        if (movepos.magnitude < 0.1f) escape = false;
        rblion.velocity = Vector3.zero;
        rblion.angularVelocity = Vector3.zero;
        Move(direction);
        oldpos = transform.position;
    }
        



    
    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("herbivore"))
 
        {
            escape = false;
            numberofpastebeforeclone -= 1;
            if (numberofpastebeforeclone == 0)
            {
    
                numberofpastebeforeclone = 3;
                Vector3 newpos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z - 1);
                GameObject t = Instantiate(Lion, newpos, transform.rotation);
                t.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            }
    }
    private void setlife()
    {
        lifelaps -= 1; 
        speed -= 0.1f;
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        if (lifelaps == 0)
        {
            Destroy(gameObject);
        }

    }
}
