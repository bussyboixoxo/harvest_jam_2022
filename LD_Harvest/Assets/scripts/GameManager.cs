using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject currentAnimal;
    
    public GameObject SquirlL;
    public GameObject SquirlR;
    public GameObject SquirlU;
    public GameObject SquirlD;
    public GameObject selectedAnimalL;
    public GameObject selectedAnimalR;
    public GameObject selectedAnimalU;
    public GameObject selectedAnimalD;

    public void Update()
    {
       if(currentAnimal = SquirlL)
       {
        selectedAnimalL = SquirlL;
        selectedAnimalR = SquirlR;
        selectedAnimalU = SquirlU;
        selectedAnimalD = SquirlD;
       }
    }
    
    
    

}
