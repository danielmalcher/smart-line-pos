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
        foreach(LaserSocketPositioner socket in stateManager.laserClawController.laserSockets){
            socket.boxHasBeenRemoved = false;
        }
    }
}
