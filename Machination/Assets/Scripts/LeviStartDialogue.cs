using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeviStartDialogue : MonoBehaviour
{

    public GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag == "Player" )
        {
            Debug.Log("HI LEVI!");
            dialogue.SetActive( true );
        }
    }
}
