using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [Range(1, 10)]
    public float jumpVelocity = 7f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float speed;
    private float moveInput;

    private Rigidbody2D rb;
    public Animator animator;
    private bool isFaceRight;
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();        
	}

	void FixedUpdate ()
    {
        animator.SetFloat("Speed", Mathf.Abs(moveInput));
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (isFaceRight == false && moveInput < 0)
            Flip();
        if (isFaceRight == true && moveInput > 0)
            Flip();
	}

    void Flip()
    {
        isFaceRight = !isFaceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
            animator.SetBool("IsJumping", true);
        }

        /*if (rb.velocity.y < 0)
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;

        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            animator.SetBool("IsJumping", false);
        }*/
        if (transform.position.x < -2.9f)
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        else if (transform.position.x > 2.9f)
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
    }
}
