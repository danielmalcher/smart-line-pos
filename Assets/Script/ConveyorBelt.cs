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

    public void PowerConveyorBelt(){
        isConveyorActive = !isConveyorActive;
    }

    void FixedUpdate(){
        MoveObjects();
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.layer == 6 && !isConveyorActive){
            PowerConveyorBelt();
        }
        if(col.gameObject.layer == 6){
            objectsOnBelt.Add(col.gameObject);
            transformValue = col.gameObject.transform.position;
            Debug.Log("enter:" + Time.deltaTime);
        }
    }

    void OnCollisionExit(Collision col){
        if(col.gameObject.layer == 6){
            objectsOnBelt.Remove(col.gameObject);
            Debug.Log("exit:" + objectsOnBelt.Count);
            PowerConveyorBelt();
        }
    }

    void MoveObjects(){
        for(int i = 0; i <= objectsOnBelt.Count -1; i++){
            if(isConveyorActive){
                Debug.Log("a");
                objectsOnBelt[i].transform.position = new Vector3(objectsOnBelt[i].transform.position.x, objectsOnBelt[i].transform.position.y, transformValue.z);
                objectsOnBelt[i].transform.rotation = new Quaternion(90,90,0,0);
                objectsOnBelt[i].GetComponent<Rigidbody>().velocity = speed*direction*Time.deltaTime;
            } else {
                objectsOnBelt[i].transform.position = new Vector3(objectsOnBelt[i].transform.position.x, objectsOnBelt[i].transform.position.y, transformValue.z);
            }
        }
    }
}
