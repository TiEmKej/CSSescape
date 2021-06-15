using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    private AudioSource _audioPlayer;
    public static audioPlayer _instance;

    private void Awake(){
        if(_instance == null){
            DontDestroyOnLoad(gameObject.transform);
            _instance = this;
        }
        else if (_instance != null){
            Destroy(this.gameObject);
            return;
        }
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
