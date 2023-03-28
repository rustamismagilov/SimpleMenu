using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameControls : MonoBehaviour
{
    public void ForestPressed()
    {
        SceneManager.LoadScene("Forest");
    }

    public void CastlePressed()
    {
        SceneManager.LoadScene("Castle");
    }

    public void StreetPressed()
    {
        SceneManager.LoadScene("Street");
    }
}
