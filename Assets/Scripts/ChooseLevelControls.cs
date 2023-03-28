using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelControls : MonoBehaviour
{
    public void FirstLevelChoosed()
    {
        SceneManager.LoadScene("Forest");
    }

    public void SecondLevelChoosed()
    {
        SceneManager.LoadScene("Castle");
    }

    public void ThirdLevelChoosed()
    {
        SceneManager.LoadScene("City");
    }
}
