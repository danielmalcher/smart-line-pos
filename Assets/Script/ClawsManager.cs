using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawsManager : MonoBehaviour
{
    [SerializeField]private GameObject[] claws;

    void Start(){
        claws = GameObject.FindGameObjectsWithTag("Claw");
    }

    public bool GetClawStatus(){
        foreach (var claw in claws){
            if(claw.GetComponent<ClawController>().isHoldingBox == true){
                return claw.GetComponent<ClawController>().isHoldingBox;
            }
        }

        return false;
    }
}
