using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackagingController : MonoBehaviour
{
    [SerializeField]private GameObject clawPackaging;

    public Animator packagingAnimator;

    void Start()
    {
        packagingAnimator = clawPackaging.GetComponent<Animator>();
    }

    public void PackageBox(){
        packagingAnimator.SetBool("getBox", true);
    }
}
