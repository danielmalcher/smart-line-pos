using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPrintState : IState
{
    public void OnEnter(StateManager stateManager){
        stateManager.laserClawController.StartLaserPrint();
    }

    public void UpdateState(StateManager stateManager){
        stateManager.ChangeState(stateManager.assemblyState);
    }

    public void OnExit(StateManager stateManager){
        for(int i = 0; i <= stateManager.laserClawController.laserSockets.Count -1; i++){
            stateManager.laserClawController.laserSockets[i].boxHasBeenRemoved = false;
        }
    }
}
