using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPrintTriggerer : MonoBehaviour
{
    [SerializeField]private StateManager stateManager;
    [SerializeField]private VisualInspectionStateTransitioner visualInspectionTrans;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Lid"){
            stateManager.laserPrintState.OnEnter(stateManager);
            visualInspectionTrans.activated = false;
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Lid"){
            stateManager.laserPrintState.OnExit(stateManager);
        }
    }
}
