using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            startGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Close();
        }
    }

    public void startGame()
    {
        Debug.Log("PlayGame");
        SceneManager.LoadScene("SampleScene");
    }

    public void Close()
    {
        Debug.Log("CloseGame");
        Application.Quit();
    }
}
