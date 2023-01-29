using UnityEngine;
using UnityEngine.UI;

public class Placement : MonoBehaviour
{
     public GameObject targetObject;
     public GameObject currentAnimal;
     public GameManager gm;
     public bool goingLeft;
     public bool goingRight;
     public bool goingDown;
     public bool goingUp;

     private void Start()
     {
        gm = FindObjectOfType<GameManager>();
     }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            targetObject.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                if(goingLeft)
                {
                    Instantiate(gm.selectedAnimalL, transform.position, Quaternion.identity);
                }
                if(goingRight)
                {
                    Instantiate(gm.selectedAnimalR, transform.position, Quaternion.identity);
                }
                if(goingUp)
                {
                    Instantiate(gm.selectedAnimalU, transform.position, Quaternion.identity);
                }
                if(goingDown)
                {
                    Instantiate(gm.selectedAnimalD, transform.position, Quaternion.identity);
                }
                
            }
        }
        else
        {
            targetObject.SetActive(false);
        }
    }
}