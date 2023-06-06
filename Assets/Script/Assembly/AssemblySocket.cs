using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblySocket : MonoBehaviour
{
    [SerializeField]private List<GameObject> boxPieces;
    [SerializeField]public GameObject wholeBox;
    private int nextPartToActivate = 0;
    private Transform target;
    [SerializeField]private AssemblyController controller;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 6){
            boxPieces[nextPartToActivate].SetActive(true);
            nextPartToActivate++;
            Destroy(col.gameObject);
            Debug.Log(nextPartToActivate);
            if(nextPartToActivate >= 4){
                ActivateBox();
                controller.ReturnWholeBox();
            }
        }
    }

    void ActivateBox(){
        wholeBox.GetComponent<Rigidbody>().isKinematic = false;
        wholeBox.GetComponent<BoxCollider>().enabled = !wholeBox.GetComponent<BoxCollider>().enabled;
        wholeBox.GetComponent<SphereCollider>().enabled = !wholeBox.GetComponent<SphereCollider>().enabled;
    }
}
