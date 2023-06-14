using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAssemblyClaw : MonoBehaviour
{
    private Animator rightArmAnimator;

    void Start()
    {
        rightArmAnimator = gameObject.GetComponent<Animator>();
    }

    public void GrabBottomLid(){
        rightArmAnimator.SetTrigger("grabBottom");
    }
}
