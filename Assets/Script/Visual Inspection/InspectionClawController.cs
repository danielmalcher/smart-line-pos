using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionClawController : MonoBehaviour
{
    private Animator clawAnimator;
    private bool isIdle = false;
    // Start is called before the first frame update
    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }

    void InspectBoxPart(){
        isIdle = VerifyActiveAnimation();
        if(isIdle){
            clawAnimator.SetTrigger("grabBox");
        }
    }

    bool VerifyActiveAnimation(){
        if(clawAnimator.GetCurrentAnimatorStateInfo(0).IsName("clawGrabBox")){
            return isIdle = true;
        } else {
            return isIdle = false;
        }
    }
}
