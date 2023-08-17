using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.conveyorBelt.PowerConveyorBelt();
        stateManager.autoscrewController.Screw();
    }

    public void UpdateState(StateManager stateManager){
        OnEnter(stateManager);
        stateManager.visualInspectionState.OnEnter(stateManager);
        OnExit(stateManager);
    }

    public void OnExit(StateManager stateManager){
        stateManager.autoscrewController.isAnimationOver = false;
        stateManager.autoscrewController.clawSocket.SetActive(true);
    }
}
