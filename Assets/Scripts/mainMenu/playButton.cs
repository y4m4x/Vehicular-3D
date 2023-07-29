using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Close()
    {
        Application.Quit();
    }
}
