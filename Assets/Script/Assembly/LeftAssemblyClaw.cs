using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAssemblyClaw : MonoBehaviour
{
    private Animator leftArmAnimator;

    void Start()
    {
        leftArmAnimator = gameObject.GetComponent<Animator>();
    }

    public void GrabBoard(){
        leftArmAnimator.SetTrigger("grabBoard");
    }

    public void ReturnBox(){
        leftArmAnimator.SetTrigger("returnBox");
    }
}
