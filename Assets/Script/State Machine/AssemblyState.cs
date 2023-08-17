using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.assemblyController.AssembleBox();
    }

    public void UpdateState(StateManager stateManager){
        stateManager.ChangeState(stateManager.autoscrewState);
    }

    public void OnExit(StateManager stateManager){
        stateManager.assemblyController.ResetPositions();
        stateManager.assemblyController.SpawnNewBox();
    }
}
