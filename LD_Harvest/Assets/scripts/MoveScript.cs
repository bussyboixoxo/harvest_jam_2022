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

private Animator anim;

public float carriedPoints;


void Start()
{
    anim = GetComponent<Animator>();
}
void Update()
{
    if(transform.position.y + 1 >= boardHeight/2) //hits top
    {
        FlipDirection();
    }
    if(transform.position.y - 1 <= -boardHeight/2) //hits bottom
    {
        FlipDirection();
    }
    if(transform.position.x + 1 >= boardWidth/2) //hits right
    {
        FlipDirection();
    }
    if(transform.position.x - 1 <= -boardWidth/2) //hits left
    {
        FlipDirection();
    }
}

public void Move()
{
    
    if(goingLeft)
    {
        transform.position -= new Vector3(moveSpeed, 0, 0);
        anim.SetTrigger("move");
    }
    if(goingRight)
    {
        transform.position += new Vector3(moveSpeed, 0, 0);
        anim.SetTrigger("move");
    }
    if(goingUp)
    {
        transform.position += new Vector3(0, moveSpeed, 0);
        anim.SetTrigger("move");
    }
    if(goingDown)
    {
        transform.position -= new Vector3(0, moveSpeed, 0);
        anim.SetTrigger("move");
    }  
    
}



public void GetFruit(float points)
{
    carriedPoints = points;
}


public void FlipDirection()
{
    if(goingUp)
    {
        goingUp = false;
        goingDown = true;
    }
    if(goingDown)
    {
        goingUp = true;
        goingDown = false;
    }
    if(goingRight)
    {
        goingRight = false;
        goingLeft = true;
    }
    if(goingLeft)
    {
        goingRight = true;
        goingLeft = false;
    }
}












}




