using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netPJ1 : MonoBehaviour
{

    public GameObject PJ2ScoreScreen;

    public GameManagerPJ2 GameManager;

    public float score;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            PJ2ScoreScreen.SetActive(true);
            GameManager.addGoal();
            SceneManager.LoadScene("SampleScene");
        }
    }
}
