using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Vector3 pos = new Vector3(-180, -3, 0);
    public float speed = 30f;
    
    // this is for storing your rigidbody use RigidBody2D for 2D game
    private Rigidbody2D obj;

    void Start()
    {
        //setting the value, use <Rigidbody2D> for 2D Game
        obj = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // moving the object on x, you can choose direction (x,y,z) change to vector2 if its 2D (x,y)
        obj.velocity = new Vector3( -1 * speed, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "wall")
        {
            this.transform.position = pos;
        }



    }
}

