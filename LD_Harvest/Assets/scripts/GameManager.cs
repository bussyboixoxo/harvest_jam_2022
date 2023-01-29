using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    public bool squirl;
    public bool crow;
    public GameObject SquirlL;
    public GameObject SquirlR;
    public GameObject SquirlU;
    public GameObject SquirlD;
    public GameObject RavenL;
    public GameObject RavenR;
    public GameObject RavenU;
    public GameObject RavenD;
    public GameObject selectedAnimalL;
    public GameObject selectedAnimalR;
    public GameObject selectedAnimalU;
    public GameObject selectedAnimalD;


    public void Start()
    {
        
    }
    public void Update()
    {
        
       if(squirl)
       {
        selectedAnimalL = SquirlL;
        selectedAnimalR = SquirlR;
        selectedAnimalU = SquirlU;
        selectedAnimalD = SquirlD;
       }
       if(crow)
       {
        selectedAnimalL = RavenL;
        selectedAnimalR = RavenR;
        selectedAnimalU = RavenU;
        selectedAnimalD = RavenD;
       }
    }
    
    
    public void UISquirlSelect()
    {
        squirl = true;
        crow = false;
    }
    public void UIRavenSelect()
    {
        squirl = false;
        crow = true;
    }

    public void animalCheck()
    {
        if(!squirl && !crow)
        {
            
        }
    }
}
