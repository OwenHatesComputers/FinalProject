using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCollider : MonoBehaviour
{

    public GameObject dog;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "sewers")
        {
            Debug.Log("I hit the sewer");
            dog.GetComponent<DogController>().setSpeedZero();
        }
    }
    private void Update()
    {
        transform.position = dog.transform.position;
    }
}
