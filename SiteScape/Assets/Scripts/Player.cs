using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Zmienne
    float axisX = 0f;
    float runSpeed = 200f;
    float jumpSpeed = 8.25f;
    //Komponenty
    Rigidbody2D rb2d;
    BoxCollider2D bxC2D;
    AudioSource audioPlay;

    private void Start(){
        //Przypisanie komponentów
        rb2d = GetComponent<Rigidbody2D>();
        bxC2D = GetComponent<BoxCollider2D>();
        audioPlay = GetComponent<AudioSource>();
    }


    private void Update(){
        AxisUpdate();
        Jump();
    }

    private void FixedUpdate() {
        Movement();
        
    }

    public void PlayAudio(){
        audioPlay.Play();
    }

    private void Jump(){
        if(bxC2D.IsTouchingLayers(LayerMask.GetMask("Blocks"))){
            if(Input.GetButtonDown("Jump")){
                rb2d.velocity += new Vector2(0f, jumpSpeed);
            }
        }
    }

    private void Movement(){
        rb2d.velocity = new Vector2(axisX * Time.fixedDeltaTime * runSpeed, rb2d.velocity.y);
    }

    private void AxisUpdate(){
        axisX = Input.GetAxis("Horizontal");
    }
}
