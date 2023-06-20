using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField]private GameObject top;
    [SerializeField]private GameObject bottom;

    private Vector3 topTransformPos;
    private Quaternion topTransformRot;

    private Vector3 bottomTransformPos;
    private Quaternion bottomTransformRot;

    void Start(){
        topTransformPos = top.transform.position;
        topTransformRot = top.transform.rotation;

        bottomTransformPos = bottom.transform.position;
        bottomTransformRot = bottom.transform.rotation;
    }

    public void ResetBoxPosition(){
        top.transform.position = topTransformPos;
        top.transform.rotation = topTransformRot;

        bottom.transform.position = bottomTransformPos;
        bottom.transform.rotation = bottomTransformRot;
    }

    public void ResetScene(string scene){
        SceneManager.LoadScene(scene);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
