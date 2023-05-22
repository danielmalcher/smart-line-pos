using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewController : MonoBehaviour
{
    private Animator screwAnimator; 
    // Start is called before the first frame update
    void Start()
    {
        screwAnimator = gameObject.GetComponent<Animator>();      
    }

    void Screw(){
        screwAnimator.SetTrigger("setScrew");
    }
}
