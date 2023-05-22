using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyController : MonoBehaviour
{

    [SerializeField]private GameObject rightArm;
    [SerializeField]private GameObject leftArm;

    private Animator rightArmAnimator;
    private Animator leftArmAnimator;
    // Start is called before the first frame update
    void Start()
    {
        rightArmAnimator = rightArm.GetComponent<Animator>();
        leftArmAnimator = leftArm.GetComponent<Animator>();
    }

    void grabBottomLid(){
        rightArmAnimator.SetTrigger("grabBottom");
    }

    void placeBattery(){
        leftArmAnimator.SetTrigger("grabBattery");
    }

    void placeBoard(){
        rightArmAnimator.SetTrigger("grabBoard");
    }

    void grabTopLid(){
        leftArmAnimator.SetTrigger("grabTop");
    }

    void returnBoxToConveyor(){
        rightArmAnimator.SetTrigger("returnBox");
    }
}
