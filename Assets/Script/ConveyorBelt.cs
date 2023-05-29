using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    private bool isConveyorActive = true;
    [SerializeField]private float speed;
    [SerializeField]private Vector3 direction;
    [SerializeField]private List<GameObject> objectsOnBelt;
    private Vector3 transformValue;

    public void PowerConveyorBelt(){
        isConveyorActive = !isConveyorActive;
    }

    void FixedUpdate(){
        MoveObjects();
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.layer == 6){
            transformValue = col.gameObject.transform.position;
            objectsOnBelt.Add(col.gameObject);
        }
    }

    void OnCollisionExit(Collision col){
        if(col.gameObject.layer == 6){
            objectsOnBelt.Remove(col.gameObject);
        }
    }

    void MoveObjects(){
        for(int i = 0; i <= objectsOnBelt.Count -1; i++){
            objectsOnBelt[i].transform.rotation = new Quaternion(0,90,0,0);
            objectsOnBelt[i].transform.position = new Vector3(objectsOnBelt[i].transform.position.x, objectsOnBelt[i].transform.position.y, transformValue.z);
            objectsOnBelt[i].GetComponent<Rigidbody>().velocity = speed*direction*Time.deltaTime;
        }
    }
}
