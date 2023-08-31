using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrewTriggerer : MonoBehaviour
{
    [SerializeField]private StateManager stateManager;
    [SerializeField] private BoxCollider collider;
    public GameObject box;
    public Vector3 wholeBoxPosition;
    public Quaternion wholeBoxRotation;
    [SerializeField]private AutoscrewController autoscrewController;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.layer == 11 && !autoscrewController.isAnimationOver){
            collider.enabled = false;
            stateManager.autoscrewState.OnEnter(stateManager);
            box = col.gameObject;
            wholeBoxPosition = col.gameObject.transform.position;
            wholeBoxRotation = col.gameObject.transform.rotation;
        }
    }
}
