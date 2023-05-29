using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    [SerializeField]private GameObject clawSocket;
    private Transform boxTransform;
    private bool holdingBox = false;
    
    void OnTriggerStay(Collider col){
        if(col.gameObject.layer == 9){
            ReleaseTarget(boxTransform, col.transform);
        }
        if(col.gameObject.layer == 6){
            boxTransform = col.gameObject.transform;
            GrabTarget(boxTransform);
        }
    }

    void GrabTarget(Transform targetTransform){
        targetTransform.position = clawSocket.transform.position;
        targetTransform.rotation = clawSocket.transform.rotation;
        Debug.Log(targetTransform);
    }

    void ReleaseTarget(Transform targetTransform, Transform destinationTransform){
        targetTransform = destinationTransform;
    }
}
