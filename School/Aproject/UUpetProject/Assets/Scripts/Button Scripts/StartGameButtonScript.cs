using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButtonScript : MonoBehaviour
{
    //Switches scenes to the game scene
    public void GameSceneSwitcher()
    {
        SceneManager.LoadScene(1);
    }
}
