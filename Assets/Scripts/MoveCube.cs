using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private int flip = 1;
    public float speed = 1F;
    public double front = 67;
    public double back = 57;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = rb.velocity;
        Vector3 loc = rb.position;
        
        if (flip == 1) //go forward
        {
            vel.z = speed;
        }
        else
        {
            vel.z = -1*speed;
        }
        if (loc.z >= front)
        {
            flip = 0; //go back
            vel.z = -1*speed;
        }
        if (loc.z <= back)
        {
            flip = 1;
            vel.z = speed;
        }
        //vel.y = 0.5F;
        rb.velocity = vel;
    }
}
