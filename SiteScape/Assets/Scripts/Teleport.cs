using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    GameManager gameManager;
    BoxCollider2D bxC2D;
    private void Start() {
        gameManager = FindObjectOfType<GameManager>();
        bxC2D = GetComponent<BoxCollider2D>();
        bxC2D.enabled = false;
    }
    void Update()
    {
        if (gameManager.GetMaxPoints() == gameManager.GetScore()){
            bxC2D.enabled = true;
        }
    }
}
