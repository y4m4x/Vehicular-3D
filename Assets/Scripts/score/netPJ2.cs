using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netPJ2 : MonoBehaviour
{

    public GameObject PJ1ScoreScreen;
    
    public float pointsToAdd;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Ball")
        {
            PJ1ScoreScreen.SetActive(true);
        }
    }
}
