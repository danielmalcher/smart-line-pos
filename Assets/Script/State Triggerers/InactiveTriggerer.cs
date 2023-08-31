using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveTriggerer : MonoBehaviour
{
    [SerializeField]private StateManager stateManager;
    [SerializeField] private GameObject[] boxes;
    private int boxNumber = 0;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 11){
            Destroy(col.gameObject);
            if(boxNumber <= 23){
                boxes[boxNumber].SetActive(true);
                boxNumber += 1;
            } else {
                boxNumber = 0;
                foreach(GameObject box in boxes){
                    box.SetActive(false);
                }
            }
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.layer == 11){
            stateManager.packagingState.OnExit(stateManager);
        }
    }
}
