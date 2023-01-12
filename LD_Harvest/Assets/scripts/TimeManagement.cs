using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagement : MonoBehaviour
{
public float timer = 10f;
private float maxTimer;

public bool paused;

void Start()
{
    maxTimer = timer;
}


void Update()
{
    if(!paused)
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
    {
        timer = maxTimer; // reset timer to x seconds

        GameObject[] animals = GameObject.FindGameObjectsWithTag("Animals");
        foreach (GameObject animal in animals)
        {
            MoveScript moveScript = animal.GetComponent<MoveScript>();
            if (moveScript != null)
            {
                moveScript.Move();
            }
        }

        //////////////////////////Enemys
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemys)
        {
            MoveScriptE moveScript = enemy.GetComponent<MoveScriptE>();
            if (moveScript != null)
            {
                moveScript.Move();
            }
        }
       
    }

    }
   

    
}
}
