using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackagingState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.conveyorBelt.PowerConveyorBelt();
        stateManager.packagingController.PackageBox();
    }

    public void UpdateState(StateManager stateManager){
        stateManager.ChangeState(stateManager.inactiveState);
    }

    public void OnExit(StateManager stateManager){
    }
}
