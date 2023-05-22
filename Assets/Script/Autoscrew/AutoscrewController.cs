using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewController : MonoBehaviour
{
    [SerializeField]private GameObject autoscrewHead;
    private Animator screwHead; 
    // Start is called before the first frame update
    void Start()
    {
        screwHead = autoscrewHead.GetComponent<Animator>();      
    }

    void Screw(){
        screwHead.SetTrigger("setScrew");
    }
}
