using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]private List<AudioSource> moduleExplanations;

    void StopOverlappingAudio()
    {
        for(int i = 0; i <= moduleExplanations.Count -1; i++){
            if(moduleExplanations[i].isPlaying){
                moduleExplanations[i].Stop();
            }
        }
    }

    public void PlayAudio(int moduleNumber)
    {
        StopOverlappingAudio();
        moduleExplanations[moduleNumber].Play();
    }
}
