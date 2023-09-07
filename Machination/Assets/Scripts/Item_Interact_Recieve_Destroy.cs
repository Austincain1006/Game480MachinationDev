using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Interact_Recieve_Destroy : MonoBehaviour
{
    public BoxCollider2D itemBounds;
    

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
            Debug.Log("Amogus");
        }
    }
    
}
