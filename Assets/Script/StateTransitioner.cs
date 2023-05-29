using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateTransitioner : MonoBehaviour
{

    [SerializeField]private StateManager stateManager;

    void Start(){
        Debug.Log(stateManager);
        Debug.Log(stateManager.currentState);
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 6){
            stateManager.currentState.UpdateState(stateManager);
        }
    }
}
