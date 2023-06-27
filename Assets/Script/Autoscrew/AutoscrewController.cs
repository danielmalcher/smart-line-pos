using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewController : MonoBehaviour
{
    private Animator screwAnimator; 
    public bool isAnimationOver;

    public GameObject clawSocket;

    void Start()
    {
        screwAnimator = gameObject.GetComponent<Animator>();      
    }

    void Update(){
        if(isAnimationOver){
            clawSocket.SetActive(false);
        }
    }

    public void Screw(){
        screwAnimator.SetTrigger("setScrew");
    }
}
