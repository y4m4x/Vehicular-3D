using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManagerPJ1 : MonoBehaviour
{
    public int scorePJ1;
    public int scorePJ2;
    public Text textPJ1;
    public Text textPJ2;
    public static GameManagerPJ1 instance;

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

    private void Start()
    {
        textPJ1 = GameObject.FindGameObjectWithTag("PJ1Score").GetComponent<Text>();
        textPJ2 = GameObject.FindGameObjectWithTag("PJ2Score").GetComponent<Text>();
    }

    public void Win(int playerToWin)
    {
        if (playerToWin == 1)
        {
            SceneManager.LoadScene("VictoryPJ1");
        }

        else if (playerToWin == 2)
        {
            SceneManager.LoadScene("VictoryPJ2");
        }
    }

    public void addGoal(int playerToScore)
    {
        if (playerToScore == 1)
        {
            scorePJ1++;
            textPJ1.text = "Player 1: " + scorePJ1;
        }

        else if (playerToScore == 2)
        {
            scorePJ2++;
            textPJ2.text = "Player 2: " + scorePJ2;
        }

        if (scorePJ1 == 3 || scorePJ2 == 3)
        {
            Win(playerToScore);
        }

        else
        {
            Invoke("ReloadScene", 2f);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
