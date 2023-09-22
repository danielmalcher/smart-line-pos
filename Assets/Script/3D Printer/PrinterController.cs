using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterController : MonoBehaviour
{
    [SerializeField]private GameObject printerDoor;
    [SerializeField]public Animator printerAnimator;
    public ClawPrinterController clawController;
    private AudioSource printerSound;

    public bool isPrinterDoorOpen = false;
    public bool isPrinting = false;

    [SerializeField]private GameObject boxLid;
    [SerializeField]private GameObject boxBottom;
    private Vector3 boxLidInitialPos;
    private Quaternion boxLidInitialRot;
    private Vector3 boxBottomInitialPos;
    private Quaternion boxBottomInitialRot;

    [SerializeField]private GameObject boxLidPrefab;
    [SerializeField]private GameObject boxBottomPrefab;

    [SerializeField]private InspectionClawController inspectionClawController;

    private bool boxesHaveSpawned = false;
    
    void Start(){
        boxLidInitialPos = boxLid.transform.position;
        boxLidInitialRot = boxLid.transform.rotation;

        boxBottomInitialPos = boxBottom.transform.position;
        boxBottomInitialRot = boxBottom.transform.rotation;
    }

    void FixedUpdate()
    {
        setPrinterDoorStatus();

        if(inspectionClawController.isInspectionOver == true){
            PrintBox();
        }
    }

    public void PrintBox(){
        clawController.clawAnimator.SetBool("grabbingBox", true);
        printerAnimator.SetBool("isOpen", true);
        isPrinting = false;
        isPrinterDoorOpen = true;
        isPrinting = true;
        inspectionClawController.isInspectionOver = false;
        boxesHaveSpawned = false;
    }

    void setPrinterDoorStatus(){
        if(isPrinting){
            printerAnimator.SetBool("isOpen", true);
            isPrinting = false;
            isPrinterDoorOpen = true;
        }
    }

    public void SpawnNewBoxes(){
        if(!boxesHaveSpawned){
            Instantiate(boxLidPrefab, boxLidInitialPos, boxLidInitialRot);
            Instantiate(boxBottomPrefab, boxBottomInitialPos, boxBottomInitialRot);
            boxesHaveSpawned = true;
        }
    }
}
