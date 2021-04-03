using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 10f;
    public float gravityConstant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        transform.Translate(translationX, 0f, 0f);
        float translationY = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime - (gravityConstant * 0.1f);
        transform.Translate(0f, translationY, 0f);
        //transform.Translate(0f, -0.1f, 0f);
    }
}
 