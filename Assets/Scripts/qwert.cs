using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qwert : MonoBehaviour
{
    public bool Ground = false;
    public LayerMask WhatIsGround;
    public Transform groundcheck;
    private float groundRadius = 0.2f;
    [Range(1, 10)]
    public float jumpVelocity = 7f;
    public float hSpeed;
    float speedX;
    public float VImpulse;
    Rigidbody2D rb;
    private bool isFaceRight;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    public void LeftDown()
    {
        speedX = -hSpeed;
        if (isFaceRight == false)
            Flip();
    }
    public void RightDown()
    {
        speedX = hSpeed;
        if (isFaceRight == true)
            Flip();
    }
    public void Stop()
    {
        speedX = 0;
    }
    public void OnJump()
    {
        if(Ground == true)
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        if (Ground == false)
            return;
       
    }
     void Update()
    {
        if (transform.position.x < -2.9f)
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        else if (transform.position.x > 2.9f)
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
    }
    void FixedUpdate()
    {
        Ground = Physics2D.OverlapCircle(groundcheck.position, groundRadius, WhatIsGround);
        transform.Translate(speedX, 0, 0);
    }
    void Flip()
    {
        isFaceRight = !isFaceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
