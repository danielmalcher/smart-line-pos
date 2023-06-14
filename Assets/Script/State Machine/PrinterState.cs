using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.printerController.PrintBox();
    }

    public void UpdateState(StateManager stateManager){
        stateManager.ChangeState(stateManager.visualInspectionState);
    }

    public void OnExit(StateManager stateManager){
        stateManager.printerController.isPrinterDoorOpen = false;
        stateManager.printerController.isPrinting = false;
    }
}
