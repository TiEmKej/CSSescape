using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Zmienne
    float axisX = 0f;
    float runSpeed = 300f;
    float jumpSpeed = 7f;
    //Komponenty
    Rigidbody2D rb2d;
    BoxCollider2D bxC2D;

    private void Start(){
        //Przypisanie komponentów
        rb2d = GetComponent<Rigidbody2D>();
        bxC2D = GetComponent<BoxCollider2D>();
    }


    private void Update(){
        AxisUpdate();
        Jump();
    }

    private void FixedUpdate() {
        Movement();
        
    }

    private void Jump()
    {
        if(bxC2D.IsTouchingLayers(LayerMask.GetMask("Blocks"))){
        if(Input.GetButtonDown("Jump")){
            rb2d.velocity += new Vector2(0f, jumpSpeed);
        }
        }
    }

    private void Movement()
    {
        rb2d.velocity = new Vector2(axisX * Time.fixedDeltaTime * runSpeed, rb2d.velocity.y);
    }

    private void AxisUpdate()
    {
        axisX = Input.GetAxis("Horizontal");
    }


}
