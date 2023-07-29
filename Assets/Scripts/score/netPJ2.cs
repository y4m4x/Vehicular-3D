using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netPJ2 : MonoBehaviour
{

    public GameObject PJ1ScoreScreen;

    public goalsControllerPJ1 goalsController;

    public float score;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            PJ1ScoreScreen = GameObject.FindWithTag("PJ1ScoreScreen");
            goalsController.addGoal();
            SceneManager.LoadScene("VictoryPJ1");
        }
    }
}
