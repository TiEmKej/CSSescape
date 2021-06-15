using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    private AudioSource _audioPlayer;

    private void Awake(){ 
        DontDestroyOnLoad(transform.gameObject);
        _audioPlayer = GetComponent<AudioSource>();
    }
 
    public void PlayMusic(){
        if(_audioPlayer.isPlaying){
             return;
        }
        _audioPlayer.Play();
    }
 
    public void StopMusic(){
        _audioPlayer.Stop();
    }
}
