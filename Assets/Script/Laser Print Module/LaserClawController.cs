using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserClawController : MonoBehaviour
{
    private Animator clawAnimator;

    private bool isBoxInRightPrinter;
    private bool isBoxInLeftPrinter;

    private int currentState = 0;

    // Start is called before the first frame update
    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
        PlaceBoxRight();
    }

    void PlaceBoxRight()
    {
        clawAnimator.SetTrigger("grabRight");
        isBoxInRightPrinter = true;
        PlaceBoxLeft();
    }

    void PlaceBoxLeft()
    {
        clawAnimator.SetTrigger("grabLeft");
        isBoxInLeftPrinter = true;
        ReturnBoxRight();
    }

    void ReturnBoxRight()
    {
        if(isBoxInLeftPrinter){
            clawAnimator.SetTrigger("returnLeft");
            isBoxInLeftPrinter = false;
            ReturnBoxLeft();
        }        
    }

    void ReturnBoxLeft()
    {
        if(isBoxInRightPrinter){
            clawAnimator.SetTrigger("returnRight");
            isBoxInRightPrinter = false;
        }
    }
}
