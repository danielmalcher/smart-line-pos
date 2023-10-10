using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]private List<AudioSource> moduleExplanations;
    private AudioSource pausedAudio;

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
        if(pausedAudio){
            EmptyPausedAudio();
        }
        StopOverlappingAudio();
        moduleExplanations[moduleNumber].Play();
    }

    void PauseAudio(){
        for(int i = 0; i <= moduleExplanations.Count -1; i++){
            if(moduleExplanations[i].isPlaying){
                moduleExplanations[i].Pause();
                pausedAudio = moduleExplanations[i];
            }
        }
    }

    void ResumeAudio(){
        pausedAudio.UnPause();
        pausedAudio = null;
    }

    void EmptyPausedAudio(){
        pausedAudio.Stop();
        pausedAudio = null;
    }

    public void ManageAudio(){
        if(pausedAudio){
            ResumeAudio();
        } else {
            PauseAudio();
        }
    }
}
