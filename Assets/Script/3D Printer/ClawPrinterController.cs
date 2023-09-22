using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawPrinterController : MonoBehaviour
{
    [SerializeField]private PrinterController printerController;
    public Animator clawAnimator;

    public bool movementEnd;

    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        finishMovement();
    }

    private void finishMovement(){
        if(movementEnd){
            printerController.isPrinterDoorOpen = false;
            printerController.printerAnimator.SetBool("isOpen", false);
            clawAnimator.SetBool("grabbingBox", false);

        }
    }
}
