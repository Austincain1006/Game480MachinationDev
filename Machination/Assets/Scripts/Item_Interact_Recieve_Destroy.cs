using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Item_Interact_Recieve_Destroy : MonoBehaviour
{
    public BoxCollider2D itemBounds;
    //Collider2D collision;
    public SpriteRenderer treeTexture;



    // Start is called before the first frame update
    void Start()
    {
        itemBounds = gameObject.GetComponent<BoxCollider2D>();
        //collision = gameObject.GetComponent<BoxCollider2D>();
        treeTexture = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    private void OnTriggerStay2D(Collider2D collision)
    {       
        if ( collision.tag == "Player" )
        {
            //Debug.Log("Amogus");

            if ( Input.GetKeyDown(KeyCode.E) ){
                Debug.Log("Amogus with swag");
                //treeTexture.transform.position = new Vector3(0, 0,)
                //treeTexture.transform.RotateAround(itemBounds.transform.position, , 20* Time.deltaTime);
                Destroy(gameObject);
                
            }
        }
    }
    
}
