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
    }

    private void Update() {
        maxPoints = GameObject.FindObjectsOfType<Point>().Length;
        if(maxPoints == 0){
            scoreText.text = "Teleport aktywny";
            teleport.Activation(true);
        }
        else{
            scoreText.text = "Fragmenty do zebrania \n" + maxPoints;
        }
    }

    public int Points(){
        Debug.Log(maxPoints);
        return maxPoints;
    }
}
