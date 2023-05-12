using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawPrinterController : MonoBehaviour
{
    [SerializeField]private PrinterController printerController;
    private Animator clawAnimator;

    public bool movementEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        checkPrinterStatus();
        finishMovement();
    }

    void GrabBox(){
        Debug.Log("Box in claw");
    }

    void checkPrinterStatus(){
        if(printerController.isPrinterDoorOpen){
            clawAnimator.SetTrigger("grabbingBox");
            GrabBox();
        }
    }

    private void finishMovement(){
        if(movementEnd){
            printerController.isPrinterDoorOpen = false;
            printerController.printerAnimator.SetBool("isOpen", false);
        }
    }
}
