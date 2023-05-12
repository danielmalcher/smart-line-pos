using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{

    [SerializeField]private GameObject initialPosition;

    [SerializeField]
    private GameObject boxLid;
    [SerializeField]
    private GameObject boxBottom;

    private Rigidbody boxLidRb;
    private Rigidbody boxBottomRb;

    private Transform spawnPosition;

    void Start()
    {
        initialPosition = gameObject;
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.layer == 7){
            spawnPosition = gameObject.transform;
            dismantleBox();
        }
    }

    void dismantleBox(){
        Instantiate(boxLid, spawnPosition);
        //Instantiate(boxBottom, spawnPosition);
        boxLidRb = boxLid.GetComponent<Rigidbody>();
        boxBottomRb = boxBottom.GetComponent<Rigidbody>();
    }
}
