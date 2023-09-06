using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/**
 * Script that controls the movement of the player
 */
public class PlayerScript : MonoBehaviour
{
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private float moveSpeed;
	private Vector2 movement;

	void Start()
	{

	}

	void Update()
	{
		// Store Player Input from A/D and W/S Keys
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		// Apply Input to Movement Function
		movePlayer(horizontalInput, verticalInput);

	}

	// Update Player Pos per Physics Frame
	public void FixedUpdate()
	{
		rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
	}

	// Set Movement Vector from Player Input
	private void movePlayer(float h, float v)
	{
		movement = Vector2.ClampMagnitude(new Vector2(h, v), 1);
	}
}
