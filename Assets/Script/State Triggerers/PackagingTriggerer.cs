using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackagingTriggerer : MonoBehaviour
{
    [SerializeField]private StateManager stateManager;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 11){
            stateManager.autoscrewState.OnExit(stateManager);
            stateManager.packagingState.OnEnter(stateManager);
        }
    }
}
