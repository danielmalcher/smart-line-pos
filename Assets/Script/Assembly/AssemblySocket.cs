using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblySocket : MonoBehaviour
{
    public int nextPartToActivate = 0;
    [SerializeField]private AssemblyController controller;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 6){
            if(nextPartToActivate >= 3){
                nextPartToActivate++;
                controller.ReturnWholeBox();
                nextPartToActivate = 0;
            }else{
                nextPartToActivate++;
            }
        }
    }
}
