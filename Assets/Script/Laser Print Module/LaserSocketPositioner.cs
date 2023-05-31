using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSocketPositioner : MonoBehaviour
{
    [SerializeField]private Transform socketPosition;
    private Transform target;
    private bool boxBeingMoved;

    void OnCollisionStay(Collision col){
        if(col.gameObject.layer == 6 && !boxBeingMoved){
            KeepTarget(col.gameObject.transform);
        }
    }

    void OnTriggerStay(Collider col){
        if(col.gameObject.layer == 10){
            boxBeingMoved = true;
        }
    }

    void KeepTarget(Transform target){
        target.position = socketPosition.position;
    }
}
