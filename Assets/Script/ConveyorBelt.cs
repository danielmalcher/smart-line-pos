using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConveyorBelt : MonoBehaviour
{
    private bool isConveyorActive = false;
    [SerializeField]private float speed;
    [SerializeField]private Vector3 direction;
    [SerializeField]private List<GameObject> objectsOnBelt;
    private Vector3 transformValue;

    public void PowerConveyorBelt(){
        isConveyorActive = !isConveyorActive;
    }

    void FixedUpdate(){
        Debug.Log(objectsOnBelt);
        MoveObjects();
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.layer == 6 && !isConveyorActive){
            PowerConveyorBelt();
        }
        if(col.gameObject.layer == 6){
            transformValue = col.gameObject.transform.position;
            objectsOnBelt.Add(col.gameObject);
        }
    }

    void OnCollisionExit(Collision col){
        if(col.gameObject.layer == 6){
            objectsOnBelt.Remove(col.gameObject);
            PowerConveyorBelt();
        }
    }

    void MoveObjects(){
        for(int i = 0; i <= objectsOnBelt.Count -1; i++){
            if(isConveyorActive){
                objectsOnBelt[i].GetComponent<Rigidbody>().isKinematic = false;
                objectsOnBelt[i].transform.position = new Vector3(objectsOnBelt[i].transform.position.x, objectsOnBelt[i].transform.position.y, transformValue.z);
                objectsOnBelt[i].transform.rotation = new Quaternion(90,90,0,0);
                objectsOnBelt[i].GetComponent<Rigidbody>().velocity = speed*direction*Time.deltaTime;
            } else {
                objectsOnBelt[i].GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
