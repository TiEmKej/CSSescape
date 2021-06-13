using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    GameManager gameManager;
    int points = 1;
    private void Start() {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D otherCollider) {
        if(otherCollider.tag == "Player"){
            gameManager.ChangeScore(points);
            Destroy(this.gameObject);
        }
    }
}
