using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    GameManager gameManager;
    ButtonManager buttonManager;
    BoxCollider2D bxC2D;
    GameObject particle;
    AudioSource teleportAudio;

    private void Start() {
        gameManager = FindObjectOfType<GameManager>();
        buttonManager = FindObjectOfType<ButtonManager>();
        teleportAudio = FindObjectOfType<AudioSource>();
        bxC2D = GetComponent<BoxCollider2D>();
        bxC2D.enabled = false;
        particle = this.transform.Find("OnParticle").gameObject;
        particle.SetActive(false);
    } 

    public void Activation(bool active){
        bxC2D.enabled = active;
        teleportAudio.Play();
        particle.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        buttonManager.LoadNextLevel();
    }
}
