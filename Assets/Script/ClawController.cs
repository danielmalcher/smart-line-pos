using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    [SerializeField]private GameObject clawSocket;
    private Transform target;
    public bool holdingBox = false;

    void OnTriggerStay(Collider col){
        if(col.gameObject.layer == 6){
            target = col.gameObject.transform;
            holdingBox = true;
            GrabTarget(target);
        }
    }
    
    private void OnTriggerExit(Collider col) {
        if(col.gameObject.layer == 6){
            holdingBox = false;
        }
    }

    void GrabTarget(Transform targetTransform){
        targetTransform.position = clawSocket.transform.position;
        targetTransform.rotation = clawSocket.transform.rotation;
    }

    void ReleaseTarget(Transform targetTransform, Transform destinationTransform){
        targetTransform = destinationTransform;
    }
}
