// Citation: Code heavily inspired by: https://www.youtube.com/watch?v=8oTYabhj248

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        // Allow player to skip typing animation through input
        if ( Input.GetMouseButtonDown(0) )
        {
            if ( textComponent.text == lines[index])
            {
                nextLine();
            } else {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void startDialogue()
    {
        index = 0;
        StartCoroutine( typeLine() );
    }

    // Type out next line character by character
    private IEnumerator typeLine()
    {
        foreach ( char c in lines[index].ToCharArray() )
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void nextLine()
    {
        if ( index < lines.Length - 1 ) {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine( typeLine() );
        } else {
            gameObject.SetActive( false );
        }

    }
}
