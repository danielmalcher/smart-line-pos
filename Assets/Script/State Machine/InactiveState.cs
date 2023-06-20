using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveState : IState
{

    private GameObject stateTransition;

    public void OnEnter(StateManager stateManager){
        stateTransition = GameObject.FindWithTag("Transition");
        stateTransition.SetActive(true);
    }

    public void UpdateState(StateManager stateManager){
        stateManager.ChangeState(stateManager.printerState);

        stateManager.sceneManagement.ResetBoxPosition();
    }

    public void OnExit(StateManager stateManager){
    }
}
