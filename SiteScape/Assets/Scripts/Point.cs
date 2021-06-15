using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    GameManager gameManager;
    Player player;

    private void Start() {
        gameManager = FindObjectOfType<GameManager>();
        player = FindObjectOfType<Player>();
    }
    private void OnTriggerEnter2D(Collider2D otherCollider) {
        if(otherCollider.tag == "Player"){
            player.PlayAudio();
            Destroy(this.gameObject);
        }
    }
}
