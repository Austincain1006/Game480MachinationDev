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

    //public GameObjectC treeTexture;



    // Start is called before the first frame update
    void Start()
    {
        itemBounds = gameObject.GetComponent<BoxCollider2D>();
        //collision = gameObject.GetComponent<BoxCollider2D>();
        treeTexture = gameObject.GetComponentInChildren<SpriteRenderer>();
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
                //treeTexture.transform.SetLocalPositionAndRotation(new UnityEngine.Vector3(0,0,0), new UnityEngine.Quaternion(0f,0f,0f,1f));
                
                //treeTexture.transform.RotateAround(itemBounds.transform.position, , 20* Time.deltaTime);
                treeTexture.transform.Rotate(0,0,-90);
                treeTexture.transform.position = new UnityEngine.Vector3(0f,0f,/**-(treeTexture.size.y/2)**/ 0f);
                //Destroy(gameObject);
                
            }
        }
    }
    
}
