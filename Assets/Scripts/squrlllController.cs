using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squrlllController : MonoBehaviour
{
    public float time;
    public GameObject acorn;
    public Vector2 acornSpeed = new Vector2 (0f, 1f);
    public GameObject squrlll;


    // Update is called once per frame
    void Update()
    {
        time = Time.time + Time.unscaledDeltaTime * 5;
        //Debug.Log(time);
        if ( time % 1f <= .002)
        {
            Debug.Log("Acorn Launched");
            GameObject acorn1 = Instantiate(acorn);
            acorn1.transform.position = squrlll.transform.position;
            acorn1.GetComponent<Rigidbody2D>().AddForce(acornSpeed*20f);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "dog")
        {
            Destroy(gameObject);
        }
    }
}
