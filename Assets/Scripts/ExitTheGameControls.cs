using UnityEngine;
using UnityEngine.UI; // Include this if you're working with UI buttons

public class QuitManager : MonoBehaviour
{
    public Button quitButton; // Assign this in the Inspector

    void Start()
    {
        // Ensure the quitButton is assigned
        if (quitButton != null)
        {
            quitButton.onClick.AddListener(QuitGame);
        }
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        // Exit play mode in the editor
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // Quit the application in the build
        Application.Quit();
        #endif
    }
}
