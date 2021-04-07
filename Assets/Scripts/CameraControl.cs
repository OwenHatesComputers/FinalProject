using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    //public GameObject = wall;
    public float movementSpeed = 10f;
    public float gravityConstant;
    public GameObject bee;
    private bool forHit;
    // Update is called once per frame
    void Start() 
    {
    forHit = bee.GetComponent<BeeCont>().hasHit;
    }
    
    void Update()
    {

        forHit = bee.GetComponent<BeeCont>().hasHit;
        if (forHit == true)
        {

        }
        else
        {
            float translationX = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
            transform.Translate(translationX, 0f, 0f);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "wall") {
            movementSpeed = 0.5f;
        }
        

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "wall") {
            movementSpeed = 33f;
        }
    }
}