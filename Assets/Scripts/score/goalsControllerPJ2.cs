using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goalsControllerPJ2 : MonoBehaviour
{
    public static goalsControllerPJ2 instance;
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
    public void addGoal()
    {
        score++;
        text.text = "Player 2: " + score;
        if (score == 3)
        {
            Win();
        }
    }
    public void Win()
    {
        SceneManager.LoadScene("VictoryPJ2");
    }
}
