using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float fruitPoints = 10f;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Animals")
        {
            col.GetComponent<MoveScript>().GetFruit(fruitPoints);
            col.GetComponent<MoveScript>().FlipDirection();
            gameObject.SetActive(false);
            
        }
    }

}
