using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal : MonoBehaviour
{
    // Start is called before the first frame update
    protected float speed;
    protected float angle;
    public virtual void Move(float speed,float angle)
    {
        transform.Rotate(new Vector3(0,angle,0) * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9, 17), transform.position.y, Mathf.Clamp(transform.position.z, -9, 19));
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        print(name + " contre " +other.name);
    }
}
