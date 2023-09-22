using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyBox : MonoBehaviour
{
    [SerializeField]private List<GameObject> boxPieces;
    public int nextPartToActivate = 0;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 6){
            if(col.gameObject.tag == "Lid"){
                
                if(col.gameObject.tag == "Lid" || col.gameObject.tag == "Bottom"){
                    Destroy(col.gameObject);
                } else {
                    col.gameObject.SetActive(false);
                }
                if(nextPartToActivate <= 3){
                    boxPieces[nextPartToActivate].SetActive(true);
                }
                ActivateBox();
            }else{
                if(col.gameObject.tag == "Lid" || col.gameObject.tag == "Bottom"){
                    Destroy(col.gameObject);
                } else {
                    col.gameObject.SetActive(false);
                }
                boxPieces[nextPartToActivate].SetActive(true);
            }
            nextPartToActivate++;
        }
    }

    void ActivateBox(){
        gameObject.layer = 11;
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        gameObject.GetComponent<BoxCollider>().enabled = true;
        this.enabled = false;
    }
}
