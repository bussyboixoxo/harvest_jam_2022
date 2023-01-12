using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScriptE : MonoBehaviour
{
public float moveSpeed = 1f;

public float patrolUnits;
private float maxPatrolUnits;
bool triggered;

public bool upAndDown;

void Start()
{
    maxPatrolUnits = patrolUnits;
}
void Update()
{
    if(patrolUnits>maxPatrolUnits && !triggered)
    {
        triggered=true;
        patrolUnits = 0;
    }
    if(patrolUnits>maxPatrolUnits && triggered)
    {
        triggered=false;
        patrolUnits = 0;
    }

    
    
}

public void Move()
{

    if(!triggered && !upAndDown)
    {
        transform.position += new Vector3(moveSpeed, 0, 0);
        patrolUnits += 1;
    }
    if(triggered && !upAndDown)
    {
        transform.position -= new Vector3(moveSpeed, 0, 0);
        patrolUnits += 1;
    }
    if(!triggered && upAndDown)
    {
        transform.position += new Vector3(0, moveSpeed, 0);
        patrolUnits += 1;
    }
    if(triggered && upAndDown)
    {
        transform.position -= new Vector3(0, moveSpeed, 0);
        patrolUnits += 1;
    }
    
}
}
