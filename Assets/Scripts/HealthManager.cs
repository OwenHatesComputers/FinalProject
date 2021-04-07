using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    int amountOfHearts = 3;
    public Image h1, h2, h3;
    public Sprite fullHeart, emptyHeart;

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
        }
        else {
            GameOver();
        }
    }

    private void GameOver() {
        Debug.Log("Game Over!");
    }
}
