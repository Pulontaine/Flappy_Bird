using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    
    public float jumpForce;
    public Rigidbody2D rb;
    public BirdAnimation birdAnimation;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            rb.velocity = new Vector2();
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            birdAnimation.StartRotation();
        }
        birdAnimation.ApplyRotation(rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("PipePart") || other.gameObject.CompareTag("Floor")){
            GameManager.instance.Lose();
        }
    }

    
}
