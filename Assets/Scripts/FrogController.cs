using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    private float jumpHeight;
    private float jumpTime;
    // Start is called before the first frame update
    void Start()
    {
    
        jumpTime = 3f;
    InvokeRepeating("Jump", jumpTime, jumpTime);
    }
    void Update() {
        jumpHeight = Random.Range(15f, 25f);
    }
    void Jump() {
        Debug.Log("Yumped");
        transform.position = transform.position + transform.up * jumpHeight;
    }
}
