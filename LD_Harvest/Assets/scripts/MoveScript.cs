using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
public float moveSpeed = 1f;
public bool goingLeft;
public bool goingRight;
public bool goingUp;
public bool goingDown;

public float boardHeight = 8;
public float boardWidth = 14;

void Update()
{
    if(transform.position.y + 1 >= boardHeight/2) //hits top
    {
        goingUp = false;
        goingDown = true;
    }
    if(transform.position.y - 1 <= -boardHeight/2) //hits bottom
    {
        goingUp = true;
        goingDown = false;
    }
    if(transform.position.x + 1 >= boardWidth/2) //hits right
    {
        goingRight = false;
        goingLeft = true;
    }
    if(transform.position.x - 1 <= -boardWidth/2) //hits left
    {
        goingRight = true;
        goingLeft = false;
    }
}

public void Move()
{
    if(goingLeft)
    {
        transform.position -= new Vector3(moveSpeed, 0, 0);
    }
    if(goingRight)
    {
        transform.position += new Vector3(moveSpeed, 0, 0);
    }
    if(goingUp)
    {
        transform.position += new Vector3(0, moveSpeed, 0);
    }
    if(goingDown)
    {
        transform.position -= new Vector3(0, moveSpeed, 0);
    }  
}












}




