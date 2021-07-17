using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
public Rigidbody2D rb;
public Transform groundCheck;
public LayerMask groundLayer;

public float speed;
public float jumpHeight;
public float CheckRadius;
public float jumpTime;
private float jumpTimeCounter;

public bool grounded;
public bool isJumping;

    void Start()
    {
     rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
      //D nadpisuje A
      if (Input.GetKey(KeyCode.D)){
        rb.velocity=new Vector2(speed,rb.velocity.y);
      }else if (Input.GetKey(KeyCode.A)) {
        rb.velocity=new Vector2(-speed,rb.velocity.y);
      }
//jump
      if (Input.GetKeyDown(KeyCode.Space) && grounded) {
        isJumping = true;
        jumpTimeCounter = jumpTime;
        rb.velocity = new Vector2(rb.velocity.x,jumpHeight+4);
      }

     if (Input.GetKey(KeyCode.Space) && isJumping && jumpTimeCounter>0) {
        rb.velocity = new Vector2(rb.velocity.x,jumpHeight);
        jumpTimeCounter-=Time.deltaTime;
     }else{
       isJumping=false;
     }

     if (Input.GetKeyUp(KeyCode.Space)) {
       isJumping=false;
     }
    }

    void FixedUpdate()
     {
       grounded = Physics2D.OverlapCircle(groundCheck.position,CheckRadius,groundLayer);
     }
}
