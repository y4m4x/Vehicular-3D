using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netPJ2 : MonoBehaviour
{

    public GameObject PJ1ScoreScreen;

    public GameManagerPJ1 GameManager;

    public float score;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            PJ1ScoreScreen.SetActive(true);
            GameManager.addGoal();
            SceneManager.LoadScene("SampleScene");
        }
    }
}
