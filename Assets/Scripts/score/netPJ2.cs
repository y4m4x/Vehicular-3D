using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netPJ2 : MonoBehaviour
{

    public GameObject PJ1ScoreScreen;

    public GameManagerPJ1 goalsController;

    private void Start()
    {
        goalsController = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerPJ1>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            PJ1ScoreScreen = GameObject.FindWithTag("PJ1ScoreScreen");
            goalsController.addGoal(1);
            PJ1ScoreScreen.SetActive(true);
        }
    }
}
