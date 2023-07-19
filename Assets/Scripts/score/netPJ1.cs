using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netPJ1 : MonoBehaviour
{

    public GameObject PJ2ScoreScreen;
    
    public float pointsToAdd;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Ball")
        {
            PJ2ScoreScreen.SetActive(true);
        }
    }
}
