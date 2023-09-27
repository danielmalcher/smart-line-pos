using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.assemblyController.SpawnNewBox();
        stateManager.assemblyController.AssembleBox();
    }

    public void OnExit(StateManager stateManager){
        stateManager.assemblyController.ResetPositions();
    }
}
