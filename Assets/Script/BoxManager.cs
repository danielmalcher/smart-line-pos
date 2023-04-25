using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{

    [SerializeField]private GameObject initialPosition;

    void Start()
    {
        initialPosition = gameObject;
    }

    public void returnToInitialPos()
    {
        gameObject.transform.position = initialPosition.transform.position;
    }
}
