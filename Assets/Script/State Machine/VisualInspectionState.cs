using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualInspectionState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.inspectionClawController.InspectBoxPart();
    }

    public void OnExit(StateManager stateManager){
        stateManager.printerController.SpawnNewBoxes();
    }
}
