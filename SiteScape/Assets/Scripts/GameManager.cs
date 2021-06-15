using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int maxPoints;
    public TMP_Text scoreText;

    Teleport teleport;

    private void Start() {
        teleport = FindObjectOfType<Teleport>();
        maxPoints = GameObject.FindObjectsOfType<Point>().Length;
        scoreText.text = "Fragmenty do zebrania \n" + maxPoints;
        GameObject.FindGameObjectWithTag("Music").GetComponent<audioPlayer>().PlayMusic();
    }
    private void Update() {
        if(GameObject.FindObjectsOfType<Point>().Length < maxPoints){
            maxPoints = GameObject.FindObjectsOfType<Point>().Length;
            if(maxPoints == 0){
                scoreText.text = "Teleport aktywny";
                teleport.Activation(true);
            }
            else{
                scoreText.text = "Fragmenty do zebrania \n" + maxPoints;
            }
        }
    }
}
