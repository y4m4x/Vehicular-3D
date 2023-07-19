using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public Text score;

    public int ScoreCounter;

    private void Start()
    {
        ScoreCounter = 0;
        PlayerScore();
    }

    public void PlayerScore()
    {
        ScoreCounter++;
        score.text = "Player 1: " + ScoreCounter;
        if (ScoreCounter >= 3)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
