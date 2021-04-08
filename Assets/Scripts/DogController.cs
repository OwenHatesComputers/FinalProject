using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
      
    public float speed = 40f;

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
        obj.velocity = new Vector3(speed, 0, 0);

    }

    public void setSpeedZero() {
        speed = 0f;
        Debug.Log("Set speed to zero");
    }

}
