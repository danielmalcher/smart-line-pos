using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackagingState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.packagingController.PackageBox();
    }

    public void OnExit(StateManager stateManager){
        stateManager.conveyorBelt.isConveyorActive = true;
        stateManager.packagingController.packagingAnimator.SetBool("getBox", false);
    }
}
