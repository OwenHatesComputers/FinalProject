using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeeCont : MonoBehaviour
{
    public bool hasHit = false;
    //public GameObject = wall;
    public float movementSpeed = 10f;
    public float gravityConstant;
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime * -1;
        transform.Translate(translationX, 0f, 0f);
        float translationY = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime - (gravityConstant * 0.1f);
        transform.Translate(0f, translationY, 0f);
        //transform.Translate(0f, -0.1f, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hive")
        {
            Debug.Log("Quit!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       

    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "flower")
        {
            hasHit = true;
            Debug.Log("Quit!");
        }
        if (other.gameObject.tag == "Enemy") {
            GameObject.Find("HealthManager").GetComponent<HealthManager>().SendMessage("LoseHeart");
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "flower")
        {
            hasHit = false;
            Debug.Log("Quit2!");
        }
    }

}
