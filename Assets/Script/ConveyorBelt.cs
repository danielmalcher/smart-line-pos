using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField]private bool isConveyorActive = false;
    [SerializeField]private float speed;
    [SerializeField]private Vector3 direction;
    [SerializeField]public List<GameObject> objectsOnBelt;
    [SerializeField]private List<GameObject> boxes;
    [SerializeField]private GameObject positionReference;
    private Vector3 transformValue;
    private Quaternion rotationValue;

    private bool boxIsAssembled = false;

    public void PowerConveyorBelt(){
        isConveyorActive = !isConveyorActive;
    }

    void FixedUpdate(){
        MoveObjects();
    }

    void OnCollisionEnter(Collision col){
        if((col.gameObject.layer == 6 || col.gameObject.layer == 11) && !isConveyorActive){
            PowerConveyorBelt();
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
    }

    void OnCollisionExit(Collision col){
        if(col.gameObject.layer == 6 || col.gameObject.layer == 11){
            objectsOnBelt.Remove(col.gameObject);
            PowerConveyorBelt();
        }
    }

    void MoveObjects(){
        for(int i = 0; i <= objectsOnBelt.Count -1; i++){
            if(isConveyorActive){
                objectsOnBelt[i].transform.position = new Vector3(objectsOnBelt[i].transform.position.x, objectsOnBelt[i].transform.position.y, transformValue.z);
                if(!boxIsAssembled){
                    objectsOnBelt[i].transform.rotation = new Quaternion(90,-90,0,0);
                }else{
                    objectsOnBelt[i].transform.rotation = rotationValue;
                }
                objectsOnBelt[i].GetComponent<Rigidbody>().velocity = speed*direction*Time.deltaTime;
            } else {
                objectsOnBelt[i].transform.position = new Vector3(objectsOnBelt[i].transform.position.x, objectsOnBelt[i].transform.position.y, transformValue.z);
            }
        }
    }
}
