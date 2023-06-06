using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    private ConveyorBelt conveyor;
    [SerializeField]private GameObject clawSocket;
    private Transform placementSocket;
    private Transform target;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 9){
            placementSocket = col.gameObject.transform;
        }
    }

    void OnTriggerStay(Collider col){
        if(col.gameObject.layer == 6  || col.gameObject.layer == 11){
            target = col.gameObject.transform;
            GrabTarget(target);
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.layer == 6 || col.gameObject.layer == 11){
            col.gameObject.transform.position = placementSocket.position;
            col.gameObject.transform.rotation = placementSocket.rotation;
        }
    }

    void GrabTarget(Transform targetTransform){
        targetTransform.position = clawSocket.transform.position;
        targetTransform.rotation = clawSocket.transform.rotation;
    }
}