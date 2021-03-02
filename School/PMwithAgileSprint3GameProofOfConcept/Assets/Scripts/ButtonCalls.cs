using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCalls : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits Scene");
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
