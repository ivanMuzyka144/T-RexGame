using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
	private Rigidbody2D rigidBody;

	private bool isGrounded = true;

	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;
	public float jumpSpeed = 450;

	Animator animanor;

	private void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
		animanor = GetComponent<Animator>();
	}


	void Update()
	{
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			rigidBody.AddForce(new Vector2(0, jumpSpeed));
			isGrounded = false;

			animanor.SetBool("isJumping", true);
		}

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			animanor.SetBool("isCrouching", true);
		}
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			animanor.SetBool("isCrouching", false);
		}


		if (rigidBody.velocity.y < 0)
		{
			rigidBody.velocity += Vector2.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		}
		else if (rigidBody.velocity.y > 0 && !Input.GetButton("Jump"))
		{
			rigidBody.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		isGrounded = true;
		animanor.SetBool("isJumping", false);
	}
}
