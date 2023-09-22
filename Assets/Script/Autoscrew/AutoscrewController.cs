using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewController : MonoBehaviour
{
    private Animator screwAnimator; 
    public bool isAnimationOver;

    public GameObject clawSocket;
    public ConveyorBelt conveyor;
    private bool isBoxScrewed;

    void Start()
    {
        screwAnimator = gameObject.GetComponent<Animator>();      
    }

    void Update(){
        if(isAnimationOver && !isBoxScrewed){
            screwAnimator.SetBool("setScrew", false);
            conveyor.PowerConveyorBelt();
            Debug.Log("Inside autoscrew Update");
            isAnimationOver = false;
            isBoxScrewed = true;
            Debug.Log(isAnimationOver);
        }
    }

    public void Screw(){
        if(!isAnimationOver){
            screwAnimator.SetBool("setScrew", true);
            isBoxScrewed = false;
        }
    }
}
