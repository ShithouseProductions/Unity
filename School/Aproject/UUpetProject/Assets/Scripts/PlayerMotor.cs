using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public float speed = 1f;
	[Tooltip("This is a force variable, which means it needs to be a very big number (eg 10.000)")]
    public float jumpForce = 1f;
	public int consecutiveJumps = 1;

	[Space]
	[Header("Input")]
	public KeyCode jumpButton = KeyCode.Space;
	public KeyCode dashButton = KeyCode.LeftShift;

    Rigidbody2D rb;
	Vector2 jumpVector;
	int jumps = 0;

	bool grounded;
	bool jumping;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();

	}

	private void FixedUpdate()
	{
		Move();
	}

	private void Update()
	{
		Jump();
		Dash();
	}

	private void Move()
	{
		float x = Input.GetAxis("Horizontal");

		if (grounded)
		rb.velocity = new Vector2(x * speed, rb.velocity.y);

		else if (!grounded) rb.velocity = new Vector2((x * speed)/2, rb.velocity.y);

		if (x != 0) print("running!");
	}

	private void Jump()
	{
		jumpVector = new Vector2(rb.velocity.x, jumpForce);
		if (Input.GetKeyDown(jumpButton))
		{
			jumps++;
			if (jumps <= consecutiveJumps)
			{
				rb.AddForce(jumpVector);
				print("jumped!");
				
			}
		}
	}

	private void Dash()
	{
		//dashing 
	}


	#region GroundCheck
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ground")
		{
			grounded = true;
			jumps = 0;
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ground")
		{
			grounded = false;
		}
	}
	#endregion
}
