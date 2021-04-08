using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "bird")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "bee")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "dog")
        {
            Destroy(gameObject);
        }

    }
}
