using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserClawController : MonoBehaviour
{
    private Animator clawAnimator;

    private bool isBoxInRightPrinter;
    private bool isBoxInLeftPrinter;

    public List<LaserSocketPositioner> laserSockets;

    void Start()
    {
        clawAnimator = gameObject.GetComponent<Animator>();
    }

    public void StartLaserPrint()
    {
        clawAnimator.SetTrigger("grabRight");
    }
}
