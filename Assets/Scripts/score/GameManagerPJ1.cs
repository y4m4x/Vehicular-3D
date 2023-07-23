using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerPJ1 : MonoBehaviour
{
    public int score;
    public Text text;
    public static GameManagerPJ1 instance;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (score == 3)
        {
            Win();
        }
    }

    public void Win()
    {
        SceneManager.LoadScene("VictoryPJ1");
    }

    public void addGoal()
    {
        score++;
        text.text = "Player 1: " + score;
    }
}
