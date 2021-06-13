using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int maxPoints;
    public TMP_Text scoreText;

    private void Start() {
        maxPoints = GameObject.FindObjectsOfType<Point>().Length;
        scoreText.text = "Zebrane fragmenty \n" + score.ToString() + "z" + maxPoints;
    }
    
    public int GetScore(){
        return score;
    }
    public void ChangeScore(int number){
        score += number;
        scoreText.text = "Zebrane fragmenty \n" + score.ToString() + "z" + maxPoints;
    }
    public int GetMaxPoints(){
        return maxPoints;
    }
}
