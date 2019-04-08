using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidMovement : MonoBehaviour {
    [Range(1, 10)]
    public float jumpVelocity = 7f;
    public float horizontalSpeed;
    float SpeedX;
    public float verticalImpulse;
    Rigidbody2D rb;
    bool isGrounded;
    private bool isFaceRight;
	// Use this for initialization
	public void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
    
    public void LeftButtonDown()
    {
        
        SpeedX = -horizontalSpeed;
        if (isFaceRight == false)
            Flip();
        Debug.Log("Pressed");
    }
    public void RightButtonDown()
    {
        SpeedX = horizontalSpeed;
        if (isFaceRight == true)
            Flip();
    }
    public void Stop()
    {
        SpeedX = 0;
        Debug.Log("Not Pressed");
    }
    public void OnClickJump()
    {
        /* rb.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);
        transform.Translate(SpeedX, 0, 0);
        SpeedX = 0; */
        if (isGrounded)
        GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
    }
    // Update is called once per frame
    public void FixedUpdate () {
        
        
   if (Input.GetKey(KeyCode.Space) && isGrounded)
            rb.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);
         transform.Translate(SpeedX, 0, 0);
         SpeedX = 0;
            
    }    
     private void OnColliderEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Object")
            isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Object")
            isGrounded = true;
    }
    void Flip()
    {
        isFaceRight = !isFaceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
