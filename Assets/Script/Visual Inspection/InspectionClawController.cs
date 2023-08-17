using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionClawController : MonoBehaviour
{
    private Animator clawAnimator;

    public bool isInspectionOver;

    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }

    void Update(){
        if(isInspectionOver){
            clawAnimator.SetBool("grabBox", false);
        }
    }

    public void InspectBoxPart(){
        clawAnimator.SetBool("grabBox", true);
    }
}
