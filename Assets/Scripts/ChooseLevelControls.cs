using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelControls : MonoBehaviour
{
    private List<string> sceneNames = new List<string>
    {
        "Forest",
        "Castle",
        "City"
        // Add other level scene names here
    };

    public void LoadLevel(int levelIndex)
    {
        if (levelIndex >= 0 && levelIndex < sceneNames.Count)
        {
            SceneManager.LoadScene(sceneNames[levelIndex]);
        }
        else
        {
            Debug.LogError("Invalid level index!");
        }
    }

    // Example method to call from UI
    public void OnLevelSelected(int levelIndex)
    {
        LoadLevel(levelIndex);
    }
}
