using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    //-701.5 106.9
    //public GameObject = wall;
    public float movementSpeed = 10f;
    public float gravityConstant;
    public GameObject bee;
    private bool forHit;
    private float xoffset = 0f;
    public float leftWallPos, RightWallPos;
    private Camera main;
    private bool go = false;
    // Update is called once per frame
    void Start() 
    {
        forHit = bee.GetComponent<BeeCont>().hasHit;
        main = GetComponent<Camera>();
        xoffset = (main.aspect * 2f * main.orthographicSize)/2f;
        Debug.Log("Width of Screen: " + xoffset);
        go = !(transform.position.x + xoffset >= RightWallPos) && !(transform.position.x - xoffset <= leftWallPos);
    }
    
    void Update()
    {
        Debug.Log("stop: " + go);
        


        if (go)
        {
            Debug.Log("Moving");
            Vector2 moveDir = new Vector2(bee.transform.position.x - transform.position.x, transform.position.y).normalized;
            float dist = Vector2.Distance(transform.position, bee.transform.position);
            Vector2 temp = moveDir * dist * movementSpeed* Time.deltaTime;
            transform.position = new Vector3(transform.position.x + temp.x, transform.position.y, transform.position.z);
        }
       
        go = (!(transform.position.x + xoffset >= RightWallPos) && !(transform.position.x - xoffset <= leftWallPos));
        if ((transform.position.x - xoffset <= leftWallPos) && bee.transform.position.x > transform.position.x)
        {
            go = true;
        }
        else if ((transform.position.x + xoffset >= RightWallPos) && bee.transform.position.x < transform.position.x) {
            go = true;
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