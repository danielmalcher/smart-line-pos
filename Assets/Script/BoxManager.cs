using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    private Vector3 transformBackup;

    void OnCollisionExit(Collision col){
        transformBackup = gameObject.transform.position;
    }

    void OnColissionEnter(Collision col){
        if(col.gameObject.layer == 7){
            gameObject.transform.position = transformBackup;
        }
    }

    void ResetBoxPosition(Vector3 socket){
        gameObject.transform.position = socket;
    }
}
