using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoadTrigger : MonoBehaviour
{
    public string destination;
    public GameObject LevelLoader;
    private LoadNewLevel LevelLoaderFunctions;

    // Start is called before the first frame update
    void Start()
    {
        LevelLoaderFunctions = LevelLoader.GetComponent<LoadNewLevel>();
    }

    // Change Level on Trigger Enter
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if ( collision.tag == "Player" )
        {
            LevelLoaderFunctions.LoadLevel( destination );
        }
    }
}
