using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scrollController : MonoBehaviour
{
    public TextMeshProUGUI button;
    public Image scroll;
    public bool test = true;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && test)
        {
            var tempColor = scroll.color;
            tempColor.a = 0f;
            scroll.color = tempColor;
            button.text = "";
            test = false;
            Time.timeScale = 1;
        }
    }
}
