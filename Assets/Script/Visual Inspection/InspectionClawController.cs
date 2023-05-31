using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionClawController : MonoBehaviour
{
    private Animator clawAnimator;

    // Start is called before the first frame update
    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }

    public void InspectBoxPart(){
        clawAnimator.SetTrigger("grabBox");
    }
}
