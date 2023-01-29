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
public bool notPaused = true;

private Animator anim;

public float carriedPoints;


void Start()
{
    anim = GetComponent<Animator>();
}
void Update()
{
    
}

public void Move()
{
    if(notPaused)
    {
        if(transform.position.y  > boardHeight/2) //hits top
    {
        anim.SetBool("isDead", true);
        GameObject.Destroy(gameObject,.25f);
        
    }
    if(transform.position.y  < -boardHeight/2) //hits bottom
    {
        anim.SetBool("isDead", true);
        GameObject.Destroy(gameObject,.25f);
        
    }
    if(transform.position.x  > boardWidth/2) //hits right
    {
        anim.SetBool("isDead", true);
        GameObject.Destroy(gameObject ,.25f);
        
    }
    if(transform.position.x  < -boardWidth/2) //hits left
    {
        anim.SetBool("isDead", true);
        GameObject.Destroy(gameObject, .25f);
    }
    
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
      
    
}



public void GetFruit(float points)
{
    carriedPoints = points;
}


/*public void FlipDirection()
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
        goingLeft = true;
        goingRight = false;
    }
    if(goingLeft)
    {
        goingRight = true;
        goingLeft = false;
    }
}

*/

}




