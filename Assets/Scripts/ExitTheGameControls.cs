using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitTheGameControls : MonoBehaviour
{
    public void ExitPressed()
    {
        /*
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
        EditorApplication.ExitPlaymode();
        */
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
