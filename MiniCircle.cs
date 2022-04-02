using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCircle : MonoBehaviour  // using Mini Circle prefabs
{
    Rigidbody2D physics;
    public float speed;
    bool MoveControl = false;
    GameObject Controller;
    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
        Controller = GameObject.FindGameObjectWithTag("Controller"); // we can use the gameOver function
    } 

    void FixedUpdate()
    {
        if (!MoveControl) // !xxxx = (xxxx = false)
        {
        physics.MovePosition(physics.position + Vector2.up * speed * Time.deltaTime);   // Vector2.up = new Vector2(0,1)
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="RotatingCircleTAG")
        {
            transform.SetParent(col.transform); // moving on together
            MoveControl = true;
            
        }
        if (col.tag=="MiniCircleTAG")
        {
            Controller.GetComponent<Controller>().gameOver(); // called controller script 
        }
    }

}
