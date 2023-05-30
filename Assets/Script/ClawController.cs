using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    private ConveyorBelt conveyor;
    [SerializeField]private GameObject clawSocket;
    [SerializeField]private Transform conveyorSocket;
    private Transform target;
    public bool holdingBox = false;

    void OnTriggerStay(Collider col){
        if(col.gameObject.layer == 6){
            Debug.Log(col.gameObject);
            target = col.gameObject.transform;
            holdingBox = true;
            GrabTarget(target);
        }
        if(col.gameObject.layer == 9){
            conveyorSocket = col.gameObject.transform;
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.layer == 6){
            col.gameObject.transform.position = conveyorSocket.position;
        }
    }

    void GrabTarget(Transform targetTransform){
        targetTransform.position = clawSocket.transform.position;
        targetTransform.rotation = clawSocket.transform.rotation;
    }
}