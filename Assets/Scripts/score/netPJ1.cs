using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netPJ1 : MonoBehaviour
{

    public GameObject PJ2ScoreScreen;

    public GameManagerPJ1 goalsController;

    private void Start()
    {
        goalsController = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerPJ1>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            PJ2ScoreScreen = GameObject.FindWithTag("PJ2ScoreScreen");
            goalsController.addGoal(2);
            PJ2ScoreScreen.SetActive(true);
        }
    }
}
