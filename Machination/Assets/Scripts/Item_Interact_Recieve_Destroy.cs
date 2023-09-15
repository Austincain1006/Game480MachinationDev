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
    public SpriteRenderer treeBaseTexture;

    public bool isNearResource;

    public bool resourceDestroyed = false;

    //public GameObjectC treeTexture;



    // Start is called before the first frame update
    void Start()
    {
        //itemBounds = gameObject.GetComponent<BoxCollider2D>();
        //collision = gameObject.GetComponent<BoxCollider2D>();
        //treeTexture = gameObject.GetComponentInChildren<SpriteRenderer>();

        //treeBaseTexture = gameObject.GetComponent<SpriteRenderer>();

        treeTexture.transform.position = new UnityEngine.Vector3(
                    gameObject.transform.position.x,
                    (treeBaseTexture.transform.localPosition.y + (treeTexture.size.y/2)),
                    gameObject.transform.position.z);

        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.E) && isNearResource && !resourceDestroyed){
                Debug.Log("Amogus with swag");
                //treeTexture.transform.SetLocalPositionAndRotation(new UnityEngine.Vector3(0,0,0), new UnityEngine.Quaternion(0f,0f,0f,1f));
                
                //treeTexture.transform.RotateAround(itemBounds.transform.position, , 20* Time.deltaTime);
                treeTexture.transform.Rotate(0,0,-90);

                treeTexture.transform.position = new UnityEngine.Vector3(
                    (gameObject.transform.position.x + (treeTexture.size.y/2) + (treeBaseTexture.size.x)),
                    (gameObject.transform.position.y),
                    gameObject.transform.position.z);

                treeTexture.sortingOrder = 2;

                resourceDestroyed = true;
                
                //Destroy(gameObject);
                
            }
    }


    
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if ( collision.tag == "Player" )
        {
            Debug.Log("Amogus Entering");

            isNearResource = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {       
        if ( collision.tag == "Player" )
        {
            Debug.Log("Amogus Leaving");

            isNearResource = false;

        }
    }

    //Maybe make new function for tree properties after it's been destroyed
    
}
