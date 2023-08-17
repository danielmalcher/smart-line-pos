using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblySocket : MonoBehaviour
{
    [SerializeField]private List<GameObject> boxPieces;
    [SerializeField]public GameObject wholeBox;
    public Vector3 wholeBoxPos;
    public Quaternion wholeBoxRotation;
    private int nextPartToActivate = 0;
    private Transform target;
    [SerializeField]private AssemblyController controller;

    void Start(){
        wholeBoxPos = wholeBox.transform.position;
        wholeBoxRotation = wholeBox.transform.rotation;
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 6){
            if(nextPartToActivate >= 3){
                boxPieces[nextPartToActivate].SetActive(true);
                nextPartToActivate++;
                if(col.gameObject.tag == "Lid" || col.gameObject.tag == "Bottom"){
                    Destroy(col.gameObject);
                } else {
                    col.gameObject.SetActive(false);
                }
                ActivateBox();
                controller.ReturnWholeBox();
            }else{
                boxPieces[nextPartToActivate].SetActive(true);
                nextPartToActivate++;
                if(col.gameObject.tag == "Lid" || col.gameObject.tag == "Bottom"){
                    Destroy(col.gameObject);
                } else {
                    col.gameObject.SetActive(false);
                }
            }
        }
    }

    void ActivateBox(){
        wholeBox.GetComponent<Rigidbody>().isKinematic = false;
        wholeBox.GetComponent<BoxCollider>().enabled = !wholeBox.GetComponent<BoxCollider>().enabled;
        wholeBox.GetComponent<SphereCollider>().enabled = !wholeBox.GetComponent<SphereCollider>().enabled;
    }

    public void DeactivateBox(){
        wholeBox.transform.position = wholeBoxPos;
        wholeBox.transform.rotation = wholeBoxRotation;
        nextPartToActivate = 0;
        for(int i = 0; i <= boxPieces.Count - 1; i++){
            boxPieces[i].SetActive(false);
        }

        wholeBox.GetComponent<Rigidbody>().isKinematic = true;
        wholeBox.GetComponent<BoxCollider>().enabled = !wholeBox.GetComponent<BoxCollider>().enabled;
        wholeBox.GetComponent<SphereCollider>().enabled = !wholeBox.GetComponent<SphereCollider>().enabled;
    }
}
