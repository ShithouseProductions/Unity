using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighscoreButtonScript : MonoBehaviour
{
    public void HighscoreSceneTransition()
    {
        SceneManager.LoadScene(3);
    }
}
