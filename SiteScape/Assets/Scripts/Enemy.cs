using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    float enemySpeed = 100f;
    float changeVector = 1f;
    float enemyPosX;
    float randomStartDirection;
    [SerializeField]float posXChange;

    Rigidbody2D rb2d;
    BoxCollider2D bx2d;
    CircleCollider2D cr2d;
    private void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        enemyPosX = transform.position.x;
        randomStartDirection = UnityEngine.Random.Range(0f,1f);
        if(randomStartDirection > 0.5f){
            changeVector *= -1f;
        }     
    }
    private void OnTriggerEnter2D(Collider2D otherObject) {
        if(otherObject.tag == "Player"){
            Debug.Log("Hit");
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene);
        }
    }
    private void FixedUpdate() {
        if(posXChange != 0){
        if(transform.position.x > enemyPosX+posXChange){
            changeVector *= -1f;
        }
        else if(transform.position.x < enemyPosX-posXChange){
            changeVector *= -1f;
        }
        rb2d.velocity = new Vector2 (enemySpeed * Time.fixedDeltaTime * changeVector, rb2d.velocity.y);
        }
    }
}
