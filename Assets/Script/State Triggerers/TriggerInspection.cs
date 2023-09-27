using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInspection : MonoBehaviour
{
    [SerializeField]private InspectionClawController inspectionClaw;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Lid" || col.gameObject.layer == 11){
            inspectionClaw.InspectBoxPart();
        }
    }
}
