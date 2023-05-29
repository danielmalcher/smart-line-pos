using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawPrinterController : MonoBehaviour
{
    [SerializeField]private PrinterController printerController;
    private Animator clawAnimator;

    public bool movementEnd;

    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        checkPrinterStatus();
        finishMovement();
    }

    void checkPrinterStatus(){
        if(printerController.isPrinterDoorOpen){
            clawAnimator.SetTrigger("grabbingBox");
        }
    }

    private void finishMovement(){
        if(movementEnd){
            printerController.isPrinterDoorOpen = false;
            printerController.printerAnimator.SetBool("isOpen", false);
        }
    }
}
