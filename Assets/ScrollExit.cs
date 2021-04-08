using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScrollExit : MonoBehaviour
{
    public TextMeshProUGUI button;
    public TextMeshProUGUI honey1;
    int honeyTotal = 0;
    public Image scroll;
    // Start is called before the first frame update

    private void Start()
    {
        honeyTotal = GameObject.Find("PlayerInfo").GetComponent<PlayerInfo>().honey;

        honey1.text = "Your Honey Total is " + honeyTotal;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Application.Quit();
        }
    }
}