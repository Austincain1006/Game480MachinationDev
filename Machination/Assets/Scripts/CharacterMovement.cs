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
    public float movementSpeed;


    void Start()
    {

    }

    void Update()
    {
        // Player Left/Right Movement
        if (Input.GetKey(KeyCode.D))
        { 
            player.transform.position += new Vector3( movementSpeed, 0, 0 ) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += new Vector3( movementSpeed * -1.0f, 0, 0 ) * Time.deltaTime;
        }

        // Player Up/Down Movement
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += new Vector3( 0, movementSpeed, 0 ) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += new Vector3( 0, movementSpeed * -1.0f, 0 ) * Time.deltaTime;
        }

    }
}
