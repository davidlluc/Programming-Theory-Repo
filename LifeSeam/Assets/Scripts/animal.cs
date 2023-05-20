using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class animal : MonoBehaviour
{
    // Start is called before the first frame update
    protected float speed;
    public bool escape=false;
    protected Vector3 direction;
    protected Vector3 origine=Vector3.zero;
    protected int lifelaps;
    protected Vector3 oldpos;

    protected virtual void Start()
    {
        oldpos = transform.position;
        InvokeRepeating("turnaroundroutine", 0, 4);
        speed = speed / 2;
    }

    
    protected virtual void Move(Vector3 pos) 
    {
        Vector3 movepos = transform.position - oldpos;
        if (movepos.magnitude < 0.1f) escape = false;
        transform.Translate(pos * speed * Time.deltaTime, Space.World);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9, 17), transform.position.y, Mathf.Clamp(transform.position.z, -9, 19));
        oldpos = transform.position;
    }
    
    protected void turnaroundroutine()
    {
        if (!escape)
        {
            Vector3 target = origine + new Vector3(Random.Range(-6, 6), 0, Random.Range(-6, 6));
            direction = (target - transform.position).normalized;
            direction.y = 0;
            transform.LookAt(target);
            
        }
        
    }
   
    
}
