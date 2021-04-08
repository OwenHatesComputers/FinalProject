using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    int amountOfHearts = 3;
    public Image h1, h2, h3;
    public Sprite fullHeart, emptyHeart;
    private bool gameOver = false;
    public TextMeshProUGUI death;
    public TextMeshProUGUI honey1;
    private int honeyTotal = 0;
    private void Start()
    {
        death.text = "";
        honey1.text = ": 0";
    }
    private void Update()
    {
        honeyTotal = GameObject.Find("PlayerInfo").GetComponent<PlayerInfo>().honey;

        honey1.text = ": " + honeyTotal;
        if (gameOver == true)
        {
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void GainHoney() {
        

    }
    public void LoseHeart() {
        if (amountOfHearts == 3) {
            h1.sprite = emptyHeart;
            amountOfHearts--;
        }
        else if (amountOfHearts == 2) {
            h2.sprite = emptyHeart;
            amountOfHearts--;
        }
        else if (amountOfHearts == 1)
        {
            h3.sprite = emptyHeart;
            amountOfHearts--;
            GameOver();
        }
        else {
            GameOver();
        }
    }

    private void GameOver() {
        GameObject.Find("PlayerInfo").GetComponent<PlayerInfo>().SendMessage("SetHoney");
        gameOver = true;
        Time.timeScale = 0;
        death.text = "You Died! Try Again!\n" +
              "Push R to Restart";
    }
}
