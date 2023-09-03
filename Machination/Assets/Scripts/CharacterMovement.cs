using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/**
 * Script that controls the movement of the player
 * 
 */
public class PlayerScript : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;

    //private Vector2 moveInput;
    public Rigidbody2D rb;


    void Start()
    {

    }

    void Update()
    {
        // Player Left/Right Movement
        if (Input.GetKey(KeyCode.D))
        { 
            player.transform.position += new Vector3( moveSpeed, 0, 0 ) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += new Vector3( moveSpeed * -1.0f, 0, 0 ) * Time.deltaTime;
        }

        // Player Up/Down Movement
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += new Vector3( 0, moveSpeed, 0 ) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += new Vector3( 0, moveSpeed * -1.0f, 0 ) * Time.deltaTime;
        }

    }

    public void FixedUpdate()
    {

    }

    private void movePlayer(Vector2 movement)
    {
        
    }
}
