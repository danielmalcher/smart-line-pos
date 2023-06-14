using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSocketPositioner : MonoBehaviour
{
    [SerializeField]private Transform socketTransform;
    private Transform target;
    public bool boxHasBeenRemoved;

    void OnCollisionStay(Collision col){
        if(col.gameObject.layer == 6 && !boxHasBeenRemoved){
            KeepTarget(col.gameObject.transform);
        }
    }

    void OnTriggerStay(Collider col){
        if(col.gameObject.layer == 10){
            boxHasBeenRemoved = true;
        }
    }

    void KeepTarget(Transform target){
        target.position = socketTransform.position;
        target.rotation = socketTransform.rotation;
    }
}
