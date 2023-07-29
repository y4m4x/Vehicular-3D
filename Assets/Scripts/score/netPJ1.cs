using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netPJ1 : MonoBehaviour
{

    public GameObject PJ2ScoreScreen;

    public goalsControllerPJ2 goalsController;

    public float score;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            PJ2ScoreScreen = GameObject.FindWithTag("PJ2ScoreScreen");
            goalsController.addGoal();
            SceneManager.LoadScene("VictoryPJ2");
        }
    }
}
