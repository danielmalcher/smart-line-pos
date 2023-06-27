using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveState : IState
{
    private GameObject[] stateTransition;

    public void OnEnter(StateManager stateManager){
        
    }

    public void UpdateState(StateManager stateManager){
        stateManager.ChangeState(stateManager.printerState);
    }

    public void OnExit(StateManager stateManager){
        stateManager.assemblyController.socket.DeactivateBox();
        stateManager.sceneManagement.ResetBoxPosition();

        foreach(GameObject transition in stateManager.sceneManagement.stateTransition){
            Debug.Log(transition);
            transition.SetActive(true);
        }
    }
}
