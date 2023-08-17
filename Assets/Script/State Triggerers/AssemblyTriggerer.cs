using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyTriggerer : MonoBehaviour
{
    [SerializeField]private StateManager stateManager;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Lid"){
            stateManager.assemblyState.OnEnter(stateManager);
        }
        if(col.gameObject.layer == 11){
            stateManager.assemblyState.OnExit(stateManager);
        }
    }
}
