using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    public float transitionTime = 1.0f;
    [SerializeField] private Animator transition;

    private void Start()
    {
        transition.SetTrigger("End");
    }

    // Loads Level via Name Input
    public void LoadLevel(string name)
    {
        StartCoroutine(LoadLevelCoroutine(name));
    }
    
    // Helper Function Coroutine to LoadLevel Function
    IEnumerator LoadLevelCoroutine(string name)
    {
        // Start Level Transition Animation
        transition.SetTrigger("Start");

        // Load Level after Animation Finish
        yield return new WaitForSeconds(transitionTime);

        // Load Level
        SceneManager.LoadScene(name);

    }

}
