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
        stateManager.sceneManagement.ResetBoxPosition();

        foreach(GameObject transition in stateManager.sceneManagement.stateTransition){
            transition.SetActive(true);
        }
    }
}
