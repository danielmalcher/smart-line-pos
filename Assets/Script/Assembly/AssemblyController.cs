using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyController : MonoBehaviour
{

    [SerializeField]private GameObject rightClaw;
    [SerializeField]private GameObject leftClaw;
    public AssemblySocket socket;

    [SerializeField]private GameObject board;
    [SerializeField]private GameObject battery;
    private Vector3 boardTransformPos;
    private Quaternion boardTransformRotation;

    private Vector3 batteryTransformPos;
    private Quaternion batteryTransformRotation;

    void Start(){
        boardTransformPos = board.transform.position;
        boardTransformRotation = board.transform.rotation;

        batteryTransformPos = battery.transform.position;
        batteryTransformRotation = battery.transform.rotation;
    }

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
        yield return new WaitForSeconds(6);
    }

    public void ResetPositions(){
        board.SetActive(true);
        battery.SetActive(true);

        board.transform.position = boardTransformPos;
        board.transform.rotation = boardTransformRotation;

        battery.transform.position = batteryTransformPos;
        battery.transform.rotation = batteryTransformRotation;
    }
}
