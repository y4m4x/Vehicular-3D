using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goalsControllerPJ1 : MonoBehaviour
{
    public static goalsControllerPJ1 instance;
    public int score;
    public Text text;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
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
        if (score == 3)
        {
            Win();
        }
    }
}
