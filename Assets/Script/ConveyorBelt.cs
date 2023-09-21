using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField]public bool isConveyorActive = true;
    [SerializeField]private float speed;
    [SerializeField]private Vector3 direction;
    [SerializeField]public List<GameObject> objectsOnBelt;
    [SerializeField]private List<GameObject> boxes;
    [SerializeField]private GameObject positionReference;
    private Vector3 transformValue;
    private Quaternion rotationValue;

    private bool boxIsAssembled = false;

    private bool isHoldingBox = false;

    [SerializeField]private ClawsManager clawsManager;



    public void PowerConveyorBelt(){
        isConveyorActive = !isConveyorActive;
    }

    void FixedUpdate(){
        MoveObjects();
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Building Part"){
            //a
        }
        if((col.gameObject.layer == 6 || col.gameObject.layer == 11) && !isConveyorActive){
            isConveyorActive = true;
        } 
        if(col.gameObject.layer == 6 || col.gameObject.layer == 11){
            objectsOnBelt.Add(col.gameObject);
            rotationValue = col.gameObject.transform.rotation;
            transformValue = col.gameObject.transform.position;
        }
        if(col.gameObject.layer == 11){
            rotationValue = col.gameObject.transform.rotation;
            boxIsAssembled = true;
        }
        if(col.gameObject.layer == 6 && boxIsAssembled){
            boxIsAssembled = false;
        }
    }

    void OnCollisionExit(Collision col){
        if(col.gameObject.layer == 6 || col.gameObject.layer == 11){
            objectsOnBelt.Remove(col.gameObject);
            isConveyorActive = false;
        }
    }

    void MoveObjects(){
        for(int i = 0; i <= objectsOnBelt.Count -1; i++){
            if(isConveyorActive){
                if(objectsOnBelt[i].layer == 6){
                    Quaternion partRotation = Quaternion.Euler(90,-90,0);
                    objectsOnBelt[i].transform.rotation = partRotation;
                }else if(objectsOnBelt[i].layer == 11){
                    objectsOnBelt[i].transform.rotation = Quaternion.Euler(0,90,0);
                }
                objectsOnBelt[i].GetComponent<Rigidbody>().velocity = speed*direction*Time.deltaTime;
            }
        }
    }
}
