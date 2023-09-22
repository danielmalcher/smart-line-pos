using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAssemblyClaw : MonoBehaviour
{
    public Animator rightArmAnimator;
    
    public bool isAnimationOver;

    void Start()
    {
        rightArmAnimator = gameObject.GetComponent<Animator>();
    }

    void Update(){
        if(isAnimationOver){
            rightArmAnimator.SetBool("grabBottom", false);
        }
    }

    public void GrabBottomLid(){
        isAnimationOver = false;
        rightArmAnimator.SetBool("grabBottom", true);
    }
}
