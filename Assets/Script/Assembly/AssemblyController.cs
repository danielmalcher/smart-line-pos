using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyController : MonoBehaviour
{

    [SerializeField]private GameObject rightClaw;
    [SerializeField]private GameObject leftClaw;

    public void AssembleBox(){
        PlaceBottom();
        StartCoroutine(Wait());
        PlaceBoard();
        StartCoroutine(Wait());
    }

    void PlaceBottom(){
        rightClaw.GetComponent<RightAssemblyClaw>().GrabBottomLid();
    }

    void PlaceBoard(){
        leftClaw.GetComponent<LeftAssemblyClaw>().GrabBoard();
    }

    public void ReturnWholeBox(){
        leftClaw.GetComponent<LeftAssemblyClaw>().ReturnBox();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
    }
}
