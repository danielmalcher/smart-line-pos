using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterController : MonoBehaviour
{
    [SerializeField]private GameObject printerDoor;
    [SerializeField]public Animator printerAnimator;
    private AudioSource printerSound;

    public bool isPrinterDoorOpen = false;
    public bool isPrinting = false;
    
    void Start()
    {
        printerSound = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        setPrinterDoorStatus();
    }

    public void PrintBox(){
        printerSound.Play();
        isPrinting = true;
    }

    void setPrinterDoorStatus(){
        if(isPrinting){
            printerAnimator.SetBool("isOpen", true);
            isPrinting = false;
        }
    }
}
