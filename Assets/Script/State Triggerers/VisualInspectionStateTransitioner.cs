using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualInspectionStateTransitioner : MonoBehaviour
{

    [SerializeField]private StateManager stateManager;
    public bool activated;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Lid"){
            stateManager.visualInspectionState.OnEnter(stateManager);
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Lid"){
            stateManager.visualInspectionState.OnExit(stateManager);
            stateManager.printerController.SpawnNewBoxes();
        }
    }
}
