using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewController : MonoBehaviour
{
    private Animator screwAnimator; 
    public bool isAnimationOver;

    public GameObject clawSocket;
    public ConveyorBelt conveyor;

    void Start()
    {
        screwAnimator = gameObject.GetComponent<Animator>();      
    }

    void Update(){
        if(isAnimationOver){
            screwAnimator.SetBool("setScrew", false);
            conveyor.PowerConveyorBelt();
            isAnimationOver = false;

        }
    }

    public void Screw(){
        if(!isAnimationOver){
            screwAnimator.SetBool("setScrew", true);
        }
    }
}
