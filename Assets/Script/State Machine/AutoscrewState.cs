using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.autoscrewController.isAnimationOver = false;
        stateManager.conveyorBelt.PowerConveyorBelt();
        stateManager.autoscrewController.Screw();
    }

    public void OnExit(StateManager stateManager){
        stateManager.autoscrewController.isAnimationOver = false;
    }
}
