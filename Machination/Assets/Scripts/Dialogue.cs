// Citation: Code heavily inspired by: https://www.youtube.com/watch?v=8oTYabhj248

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogTextDisplay;
    [SerializeField] TextMeshProUGUI nameTextDisplay;
    [SerializeField] float textSpeed;
    private string[] lines;
    private string[] names;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(textFile.text);
        dialogTextDisplay.text = string.Empty;
        nameTextDisplay.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        // Allow player to skip typing animation through input
        if ( Input.GetMouseButtonDown(0) )
        {
            if ( dialogTextDisplay.text == lines[index])
            {
                nextLine();
            } else {
                StopAllCoroutines();
                dialogTextDisplay.text = lines[index];
            }
        }
    }

    public void startDialogue(TextAsset dialog)
    {
        this.gameObject.SetActive(true);
        loadDialog(dialog);
        index = 0;
        StartCoroutine( typeLine() );
    }

    // Type out next line character by character
    private IEnumerator typeLine()
    {
        nameTextDisplay.text = names[index];
        foreach ( char c in lines[index].ToCharArray() )
        {
            dialogTextDisplay.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void nextLine()
    {
        if ( index < lines.Length - 1 ) {
            index++;
            dialogTextDisplay.text = string.Empty;
            nameTextDisplay.text = string.Empty;
            StartCoroutine( typeLine() );
        } else {
            index = 0;
            gameObject.SetActive( false );
        }

    }

    // Initialize Lines Array from File
    private void loadDialog(TextAsset inFile)
    {
        // Split Dialog File by Line Breaks
        lines = inFile.text.Split(new char[] { '\r', '\n' }, 
            System.StringSplitOptions.RemoveEmptyEntries);
        names = new string[lines.Length];

        // Separate Lines and Names
        int i = 0;
        foreach ( string s in lines)
        {
            names[i] = s.Split(":").First();
            lines[i] = s.Split(":").Last();
            i++;
        }

    }
}
