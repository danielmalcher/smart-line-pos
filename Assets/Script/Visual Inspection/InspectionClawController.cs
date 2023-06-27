using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionClawController : MonoBehaviour
{
    private Animator clawAnimator;

    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }

    public void InspectBoxPart(){
        clawAnimator.SetTrigger("grabBox");
    }
}
