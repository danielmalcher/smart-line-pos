using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveTriggerer : MonoBehaviour
{
    [SerializeField]private StateManager stateManager;
    [SerializeField] private GameObject[] boxes;
    [SerializeField]private int boxNumber = 0;
    [SerializeField]private GameObject AGV;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 11){
            stateManager.packagingState.OnExit(stateManager);
            Destroy(col.gameObject);
            if(boxNumber < 23){
                boxes[boxNumber].SetActive(true);
                boxNumber += 1;
            } else {
                boxNumber = 0;
                AGV.GetComponent<Animator>().SetTrigger("deliver");

            }
        }
        if(col.gameObject.tag == "Box Remover"){
                foreach(GameObject box in boxes){
                    box.SetActive(false);
                }
        }
    }
}
